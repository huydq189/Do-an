using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormPhieuThu : Form
    {
        public FormPhieuThu()
        {
            InitializeComponent();
        }

        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            DateTime Time=DateTime.Now;
            txtNgaylap.Text = Time.ToString("dd/MM/yyyy");
        }

        private void btnBackPT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dữ liệu mà bạn đang nhập sẽ mất khi quay về, bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result==DialogResult.OK)
            {
                this.Close();
            }
        }
        public void ResetCTPT()
        {
            txtNgayThu.Text = "";
            txtTienThu.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetCTPT();
        }


       
    }
}
