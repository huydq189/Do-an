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
    public partial class FormBaoCaoTon : Form
    {
        public FormBaoCaoTon()
        {
            InitializeComponent();
        }

        private void FormBaoCaoTon_Load(object sender, EventArgs e)
        {
            DateTime thang = DateTime.Now;
            lbThang1.Text = thang.ToString("MM");

        }
    }
}
