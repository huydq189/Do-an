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

namespace QLNS
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormThemNXB frm = new FormThemNXB();
            frm.ShowDialog();
        }
    }
}