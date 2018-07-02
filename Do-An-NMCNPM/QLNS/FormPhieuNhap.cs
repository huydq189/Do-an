using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using DAL;



namespace QLNS
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        PhieuNhap_BUS bus = new PhieuNhap_BUS();
        public string tensach;
        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachPN()
        {
            dgvphieunhap.DataSource = bus.Hienthiphieunhap();
        }
        public void HienThiDanhSachCTPN()
        {
            dgvsach.DataSource = bus.Hienthictphieunhap();
        }
        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dgvphieunhap.DataSource = bus.Hienthiphieunhap();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            dgvsach.DataSource = bus.Hienthictphieunhap();
        }
        public void Hienthitensach()
        {
            txtmasach.Text = tensach;
        }

        private void dgvsach_selectionchanged(object sender, EventArgs e)
        {
            if(dgvsach.SelectedRows.Count>0)
            {
                txtmaphieunhap.Text = dgvsach.SelectedRows[0].Cells[0].Value.ToString();
                txtmasach.Text = dgvsach.SelectedRows[0].Cells[1].Value.ToString();
                txtsoluong.Text = dgvsach.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            int dem = dgvphieunhap.Rows.Count;
            PhieuNhap_DTO p = new PhieuNhap_DTO();
            p.NgayNhap = dateTimePicker1.Value;
            p.TongTien = 0;
            p.MaPN = int.Parse(bus.LayMaPN());
            txtmaphieunhapauto.Text = p.MaPN.ToString();
            txtmaphieunhapauto.Enabled = false;
            p.MaNV = Convert.ToInt32(TTTaiKhoan.MaNV);
            txtmanv.Text = TTTaiKhoan.MaNV;
            txtmanv.Enabled = false;

            if (bus.themphieunhap(p) == false)
            {
                MessageBox.Show("Tạo Phiếu Nhập thất bại");

            }
            HienThiDanhSachPN();
            txtmaphieunhap.Text = dgvphieunhap.Rows[dem].Cells[0].Value.ToString();
        }

        private void dgvphieunhap_selectionchanged(object sender, EventArgs e)
        {
            if (dgvphieunhap.SelectedRows.Count > 0)
            {
                txtmaphieunhap.Text = dgvphieunhap.SelectedRows[0].Cells[0].Value.ToString();
                txtmaphieunhapauto.Text = dgvphieunhap.SelectedRows[0].Cells[0].Value.ToString();
                txtmanv.Text = dgvphieunhap.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void buttonbsung_Click(object sender, EventArgs e)
        {
            DataTable dt = bus.GetThamSoAll();
            int nhapmin = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            int luongtonmin = int.Parse(dt.Rows[0].ItemArray[1].ToString());

            PhieuNhap_DTO p = new PhieuNhap_DTO();
            p.MaPN = int.Parse(txtmaphieunhap.Text);
            p.MaSach = int.Parse(txtmasach.Text);
            p.SoLuong = int.Parse(txtsoluong.Text);
            try
            {

                if (txtmaphieunhap.Text != "")
                {
                    p.MaPN = int.Parse(txtmaphieunhap.Text);
                    
                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống");
                    return;
                }
                if (txtmasach.Text != "")
                {

                    p.MaSach = int.Parse(txtmasach.Text);


                }
                else
                {
                    MessageBox.Show("Mã sách không được để trống");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mã là số nguyên");
                return;
            }
            try
            {
                if (int.Parse(txtsoluong.Text) < nhapmin)
                {
                    MessageBox.Show("Số lượng phải lớn hơn số lượng quy định");
                    return;
                }
                else
                {

                    p.SoLuong = int.Parse(txtsoluong.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là kiểu số");
                return;
            }
            DataTable dt2 = bus.SlectSoLuongTon(p.MaSach);
            int luongton = int.Parse(dt2.Rows[0].ItemArray[6].ToString());
            int soluongtonnew = luongton + int.Parse(txtsoluong.Text);
            if (luongton < luongtonmin)
            {
                if (bus.themchitietphieunhap(p) == false)
                {
                    MessageBox.Show("Sách này đã có trong phiếu!");
                }
                else
                {
                    Sach_DTO s = new Sach_DTO();
                    s.MaSach = int.Parse(txtmasach.Text);
                    s.SoLuong = soluongtonnew;
                    bus.updatesoluong(s);
                    HienThiDanhSachCTPN();
                    /*BaoCaoTon_DTO bc = new BaoCaoTon_DTO();
                    bc.MaSach = s.MaSach;
                    bc.NgayPhatSinh = dtpick.Value;
                    bc.PhatSinh = "Phiếu nhập sách";
                    bc.TonDau = luongton;
                    bc.TonCuoi = soluongtonnew;
                    BaoCaoTonDAO.Insert(bc);*/
                    MessageBox.Show("Thành công");
                }
            }
            else
            {
                MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định");

            }
        }

        private void buttonxoatrang_Click(object sender, EventArgs e)
        {
            txtmaphieunhap.Clear();
            txtmasach.Clear();
            txtsoluong.Clear();
        }

        private void bosung_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO p = new PhieuNhap_DTO();
            if (txtmaphieunhapauto.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống");
                return;
            }
            else
            {
                txtmaphieunhap.Text = txtmaphieunhapauto.Text;
                txtmaphieunhap.Enabled = false;
            }
        }

        
        private void Luubutton_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhap_DTO p = new PhieuNhap_DTO();
                p.MaPN = int.Parse(txtmaphieunhap.Text);
                p.MaNV = int.Parse(txtmanv.Text);
                p.TongTien = bus.LayTongTien(p.MaPN);
                p.NgayNhap = dateTimePicker1.Value;
                if (txtmaphieunhapauto.Text == "")
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống");
                    return;
                }
                if (txtmanv.Text == "")
                {
                    MessageBox.Show("Mã nhân viên không được để trống");
                    return;
                }
                if (bus.LuuPN(p) == false)
                {
                    MessageBox.Show("Thất bại");
                    return;
                }
                else
                {
                    HienThiDanhSachPN();
                    MessageBox.Show("Thành công");
                }
            }
            catch
            {
                MessageBox.Show("Thất bại");
                return;
            }
        }       
    }
}