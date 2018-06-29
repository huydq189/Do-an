using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLNS
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        NhanVien_BUS busNV = new NhanVien_BUS();
        NhanVien_DTO NV = new NhanVien_DTO();
        Account_BUS busAC = new Account_BUS();
        Account_DTO AC = new Account_DTO();
        int Chot = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataTable dtNV = new DataTable();
            dtNV = busNV.LayNhanVien();
            dataGridView1.DataSource = dtNV;
            bingding();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            MoDK(false);
        }
        void bingding()
        {
            txbMaNV.DataBindings.Clear();
            txbMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "MaNV");
            txbHoTen.DataBindings.Clear();
            txbHoTen.DataBindings.Add("Text", dataGridView1.DataSource, "HoTen");
            txbSDT.DataBindings.Clear();
            txbSDT.DataBindings.Add("Text", dataGridView1.DataSource, "SDT");
            rTxbDiaChi.DataBindings.Clear();
            rTxbDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txbCMND.DataBindings.Clear();
            txbCMND.DataBindings.Add("Text", dataGridView1.DataSource, "CMND");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dataGridView1.DataSource, "NgaySinh");
            txbTaiKhoan.DataBindings.Clear();
            txbTaiKhoan.DataBindings.Add("Text", dataGridView1.DataSource, "TenTaiKhoan");
            txbMatKhau.DataBindings.Clear();
            txbMatKhau.DataBindings.Add("Text", dataGridView1.DataSource, "MatKhau");
            cbChucVu.DataBindings.Clear();
            cbChucVu.DataBindings.Add("Text", dataGridView1.DataSource, "ChucVu");

        }

        void GanDL(NhanVien_DTO nv,Account_DTO ac)
        {
            nv.MaNV = txbMaNV.Text.Trim();
            nv.HoTen = txbHoTen.Text.Trim();
            nv.DiaChi = rTxbDiaChi.Text.Trim();
            nv.SDT = txbSDT.Text.Trim();
            nv.CMND = txbCMND.Text.Trim();
            nv.NgaySinh = dateTimePicker1.Text.Trim();
            ac.MaNhanVien = txbMaNV.Text.Trim();
            ac.TenTaiKhoan = txbTaiKhoan.Text.Trim();
            ac.MatKhau = txbMatKhau.Text.Trim();
            ac.ChucVu = cbChucVu.Text.Trim();
        }
        void Clear()
        {
            txbHoTen.Text = "";
            rTxbDiaChi.Text = "";
            txbCMND.Text = "";
            txbMatKhau.Text = "";
            txbTaiKhoan.Text = "";
            cbChucVu.Text = "";
            dateTimePicker1.Text = "";
            txbSDT.Text = "";
        }
        void MoDK(bool a)
        {
            txbMaNV.Enabled = false;
            txbHoTen.Enabled = a;
            rTxbDiaChi.Enabled = a;
            txbCMND.Enabled = a;
            txbMatKhau.Enabled = a;
            txbTaiKhoan.Enabled = a;
            cbChucVu.Enabled = a;
            dateTimePicker1.Enabled = a;
            txbSDT.Enabled = a;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Chot = 0;
            MoDK(true);
            Clear();
            txbMaNV.Enabled = false;
            try
            {
                txbMaNV.Text = busNV.LayMaNV();
            }
            catch
            {
                MessageBox.Show("Lấy mã nhân viên không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            Chot = 1;
            MoDK(true);
            txbMaNV.Enabled = false;
            txbTaiKhoan.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                GanDL(NV, AC);
                if (!busAC.Check(AC) || !busNV.CheckNV(NV))
                {
                    MessageBox.Show("Thông tin không đầy đủ hoặc không đúng yêu cầu, vui lòng xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Chot == 0)
                {
                    if (!busNV.ThemNhanVien(NV))
                    {
                        MessageBox.Show("Thêm nhân viên không thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    else MessageBox.Show("Thêm thành công!","Thông báo",MessageBoxButtons.OK);
                    if (!busAC.AddAC(AC))
                    {
                        MessageBox.Show("Lỗi khi thêm tài khoản!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if ((!busNV.UpdateNV(NV))||(!busAC.Update(AC)))
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                }

                NhanVien_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Lỗi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có chăc muốn xóa nhân viên này?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    GanDL(NV, AC);
                    if ((!busAC.delAC(AC)) && (!busNV.Xoa(NV)))
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busNV.Search(txbSearch.Text);
            bingding();
        }
    }
}
