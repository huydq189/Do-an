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
    public partial class FormSach : DevExpress.XtraEditors.XtraForm
    {
        Sach_BUS bus = new Sach_BUS();
        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = bus.LoadDSSach();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.LoadDSSach();
        }
    }
}