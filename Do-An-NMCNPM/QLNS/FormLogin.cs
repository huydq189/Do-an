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
using DAL;
using BUS;

namespace QLNS
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                Account_DTO dto = new Account_DTO();
                Account_BUS bus_Account = new Account_BUS();
                dto.TenTaiKhoan = txbUsername.Text;
                dto.MatKhau = txbPassword.Text;
                TTTaiKhoan.MaNV = bus_Account.Login(dto);
                dto.MaNhanVien = TTTaiKhoan.MaNV;
                if (TTTaiKhoan.MaNV!= null)
                {
                    TTTaiKhoan.ChucVu = bus_Account.LayChucVu(dto);*/
                    FormQLNS a = new FormQLNS();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                    txbPassword.Text = "";
                /*}
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txbPassword.UseSystemPasswordChar = false;
            else txbPassword.UseSystemPasswordChar = true;
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (txbUsername.Text != "" && txbPassword.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            if (txbUsername.Text != "" && txbPassword.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
