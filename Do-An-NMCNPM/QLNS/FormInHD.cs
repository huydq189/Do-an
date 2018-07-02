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
    public partial class FormInHD : Form
    {
        int MaHD;
        public FormInHD()
        {
            InitializeComponent();
        }
        public FormInHD(string a) :this()
        {
            MaHD = int.Parse(a);
        }


        private void FormInHD_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dataSetHD.DataTable1, MaHD);
            this.reportViewer1.RefreshReport();
        }
    }
}
