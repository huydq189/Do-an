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
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        DataTable a = new DataTable();
        CTPN_DTO ct = new CTPN_DTO();
        PhieuNhap_BUS bus = new PhieuNhap_BUS();
        PhieuNhap_DTO et = new PhieuNhap_DTO();
        Sach_DTO sach = new Sach_DTO();
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            a = bus.Combosach();
            comboBox3.DataSource = a;
            comboBox3.DisplayMember = "TenSach";
            comboBox3.ValueMember = "TenSach";
            comboBox3.Text = " ";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormThemNXB frm = new FormThemNXB();
            frm.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string TenSach = comboBox3.Text;
                ct.MaSach = bus.getMaSach(TenSach);



                et.NGAYNHAP = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                ct.SoLuongNhap = Convert.ToInt32(textBox5.Text);
                bus.AddPHIEUNHAP(et);
                int Soluong = bus.getSoLuong(sach);
                Soluong = Soluong + ct.SoLuongNhap;
                sach.SoLuong = Soluong;
                bus.updatesoluong(sach);
                dataGridView1.DataSource = bus.SearchPN1();
            }
            catch
            {
                MessageBox.Show("Nhập không thành công ");
            }

        }
    }
}