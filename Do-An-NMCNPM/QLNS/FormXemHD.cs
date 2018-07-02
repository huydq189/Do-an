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
            catch { MessageBox.Show("Lỗi khi lấy danh sách hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            dtgHoaDon.DataSource = hd;
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dtgHoaDon.DataSource, "MaHD");
            try
            {
                cbMaKH.DataSource = busHD.LayMaKH();
                cbMaKH.ValueMember = "MaKH";
                cbMaKH.DisplayMember = "MaKH";
            }
            catch
            {
                MessageBox.Show("Lấy mã khách hàng không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormXemHD_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable a = new DataTable();
            if (radioButtonSearch.Checked)
            {
                a = busHD.SearchMaKH(cbMaKH.Text);
                dtgHoaDon.DataSource = a;
            }
            else
            {
                a = busHD.SearchDate(dateTimePicker2.Text, dateTimePicker1.Text);
                dtgHoaDon.DataSource = a;
            }
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dtgHoaDon.DataSource, "MaHD");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable cthd = new DataTable();
            try { cthd = busHD.getCTHD(textBox1.Text); } catch { MessageBox.Show("Lỗi"); }
            dtgCTHD.DataSource = cthd;
        }
    }
}