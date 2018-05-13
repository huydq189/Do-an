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
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            lbTime.Text = Time.ToString("dd/MM/yyyy");
        }
       
    }
}
