using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS
{
    public partial class frmKhachHang : Form
    {
        KhachHang_BUS busKH = new KhachHang_BUS();
        KhachHang_DTO kh = new KhachHang_DTO();
        int gruad = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = busKH.LayBangKH();
            dtgDSKH.DataSource = dtKhachHang;
            bingding();
            khoaDK(false);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            
        }
        void bingding()
        {
            txbMaKH.DataBindings.Clear();
            txbMaKH.DataBindings.Add("Text", dtgDSKH.DataSource, "MaKH");
            txbHoTen.DataBindings.Clear();
            txbHoTen.DataBindings.Add("Text", dtgDSKH.DataSource, "HoTen");
            txbSDT.DataBindings.Clear();
            txbSDT.DataBindings.Add("Text", dtgDSKH.DataSource, "SDT");
            txbEmail.DataBindings.Clear();
            txbEmail.DataBindings.Add("Text", dtgDSKH.DataSource, "Email");
            txbCMND.DataBindings.Clear();
            txbCMND.DataBindings.Add("Text", dtgDSKH.DataSource, "CMND");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dtgDSKH.DataSource, "NgaySinh");
            txbSoTIenNo.DataBindings.Clear();
            txbSoTIenNo.DataBindings.Add("Text", dtgDSKH.DataSource, "SoTienNo");

        }
        void ganDuLieu(KhachHang_DTO kh)
        {
            kh.MaKH = txbMaKH.Text.Trim();
            kh.HoTen = txbHoTen.Text.Trim();
            kh.Email = txbEmail.Text.Trim();
            kh.SDT = txbSDT.Text.Trim();
            kh.NgaySinh = dateTimePicker1.Value.ToShortDateString();
            kh.SoTienNo = txbSoTIenNo.Text.Trim();
            kh.CMND = txbCMND.Text.Trim();
        }
        void khoaDK(bool a)
        {
            txbMaKH.Enabled = a;
            txbHoTen.Enabled = a;
            txbCMND.Enabled = a;
            txbSoTIenNo.Enabled = a;
            dateTimePicker1.Enabled = a;
            txbEmail.Enabled = a;
            txbSDT.Enabled = a;
        }
        void clearKH()
        {
            txbHoTen.Text = "";
            txbCMND.Text = "";
            txbSoTIenNo.Text = "";
            dateTimePicker1.Text = "";
            txbEmail.Text = "";
            txbSDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            khoaDK(true);
            gruad = 0;
            clearKH();
            txbMaKH.Enabled = false;
            try
            {
                txbMaKH.Text = busKH.LayMaKH();
            }
            catch
            {
                MessageBox.Show("Lấy mã khách hàng không thành công!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            gruad = 1;
            khoaDK(true);
            txbMaKH.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show("Bạn có chăc muốn xóa nhân viên này?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                ganDuLieu(kh);
                {
                    MessageBox.Show("Không thể xóa khách hàng chưa đăng ký!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (busKH.XoaKH(kh))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
                
            }
            else
                return;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(kh);
            if (!busKH.CheckKH(kh))
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng quy định, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gruad == 0)
            { 
                if (busKH.ThemKhachHang(kh)) { MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK); }
                else { MessageBox.Show("Thêm thất bại thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error); }

            }
            else {
                if (busKH.UpdateKH(kh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể sửa!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgDSKH.DataSource = busKH.searchKH(txbSearch.Text);
            bingding();
        }
    }
}
