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

namespace QLNS
{
    public partial class BCTon : DevExpress.XtraEditors.XtraForm
    {
        public BCTon()
        {
            InitializeComponent();
        }
        Thongtinton_DTO Ton = new Thongtinton_DTO();
        Thongtinton_BUS BusBc = new Thongtinton_BUS();
        private void BCTon_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (BusBc.checkTT(thang.Text, nam.Text))
                {
                    MessageBox.Show("Tháng hoặc năm không hợp lệ, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Ton.Nam = int.Parse(nam.Text);
                Ton.Thang = int.Parse(thang.Text);
                DataTable a = new DataTable();
                a = BusBc.LayBaoCao(Ton);
                dataGridView2.DataSource = a;
            }
            catch
            {
                MessageBox.Show("Lập báo cáo lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            InTTTon a = new InTTTon(thang.Text, nam.Text);
            a.ShowDialog();
        }
    }
}