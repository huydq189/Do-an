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
using DTO;
using BUS;

namespace QLNS
{
    public partial class FormXemHD : DevExpress.XtraEditors.XtraForm
    {
        public FormXemHD()
        {
            InitializeComponent();
        }
        HoaDon_BUS busHD = new HoaDon_BUS();
        HoaDon_DTO HD = new HoaDon_DTO();
        private void FormXemHD_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataTable hd = new DataTable();
            try { hd = busHD.LayDuLieu(); }
            catch { MessageBox.Show("Lỗi khi lấy danh sách hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dtgHoaDon.DataSource = hd;
        }
    }
}