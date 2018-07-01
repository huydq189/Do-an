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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }
        Account_BUS BusAC = new Account_BUS();
        Account_DTO AC = new Account_DTO();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            txbMaNV.Text = TTTaiKhoan.MaNV;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            AC.MaNhanVien = TTTaiKhoan.MaNV;
            AC.MatKhau = txbMKCu.Text;
            AC.TenTaiKhoan = TTTaiKhoan.TenTaiKhoan;
            string MKmoi = txbMKMoi.Text;
            if (txbMKMoi.Text != txbXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BusAC.UpdateMK(AC,MKmoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
