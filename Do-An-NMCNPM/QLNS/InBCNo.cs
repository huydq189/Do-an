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
    public partial class InBCNo : Form
    {
        public InBCNo()
        {
            InitializeComponent();
        }
        int thang, nam;
        public InBCNo(string a,string b) : this()
        {
            thang = int.Parse(a);
            nam = int.Parse(b);
        }

        private void InBCNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBC.THONGTINNO' table. You can move, or remove it, as needed.
            this.THONGTINNOTableAdapter.Fill(this.DataSetBC.THONGTINNO,thang,nam);
            this.reportViewer1.RefreshReport();
        }
    }
}
