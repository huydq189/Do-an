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
    public partial class BCNo : DevExpress.XtraEditors.XtraForm
    {
        public BCNo()
        {
            InitializeComponent();
        }
        ThongTinNo_DTO No = new ThongTinNo_DTO();
        ThongTinNo_BUS BusBC = new ThongTinNo_BUS();

        private void BCNo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusBC.checkTT(txbThang.Text, txbNam.Text))
                {
                    MessageBox.Show("Tháng hoặc năm không hợp lệ, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                No.Nam = int.Parse(txbNam.Text);
                No.Thang = int.Parse(txbThang.Text);
                DataTable a = new DataTable();
                a=BusBC.LayBaoCao(No);
                dtgBCNo.DataSource = a;
            }
            catch
            {
                MessageBox.Show("Lập báo cáo lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            InBCNo a = new InBCNo(txbThang.Text, txbNam.Text);
            a.ShowDialog();
        }
    }
}