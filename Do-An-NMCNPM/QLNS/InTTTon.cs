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
    public partial class InTTTon : Form
    {
        public InTTTon()
        {
            InitializeComponent();
        }
        int thang, nam;

        public InTTTon(string a, string b) : this()
        {
            thang = int.Parse(a);
            nam = int.Parse(b);
        }

        private void InTTTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBC.THONGTINTONKHO' table. You can move, or remove it, as needed.
            this.THONGTINTONKHOTableAdapter.Fill(this.DataSetBC.THONGTINTONKHO,thang,nam);
            this.reportViewer1.RefreshReport();
        }
    }
}
