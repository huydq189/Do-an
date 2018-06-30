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
        Sach_DTO sach = new Sach_DTO();
        int gruad = 0;
       
        public FormSach()
        {
            InitializeComponent();
            Filltext();
        }
        private void FormSach_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            DataTable dtsach = new DataTable();
            dtsach = bus.LoadDSSach();
            dtgsach.DataSource = dtsach;
            bingding();
            khoaDK(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        void bingding()
        {
            masach.DataBindings.Clear();
            masach.DataBindings.Add("Text", dtgsach.DataSource, "MaSach");
            manxb.DataBindings.Clear();
            manxb.DataBindings.Add("Text", dtgsach.DataSource, "MaNXB");
            tensach.DataBindings.Clear();
            tensach.DataBindings.Add("Text", dtgsach.DataSource, "TenSach");
            tacgia.DataBindings.Clear();
            tacgia.DataBindings.Add("Text", dtgsach.DataSource, "TacGia");
            theloai.DataBindings.Clear();
            theloai.DataBindings.Add("Text", dtgsach.DataSource, "TheLoai");
            dongia.DataBindings.Clear();
            dongia.DataBindings.Add("Text", dtgsach.DataSource, "DonGia");
        }
        void khoaDK(bool a)
        {
            masach.Enabled = a;
            manxb.Enabled = a;
            tensach.Enabled = a;
            tacgia.Enabled = a;
            theloai.Enabled = a;
            dongia.Enabled = a;
        }
        void clearKH()
        {
            masach.Text = "";
            manxb.Text = "";
            tensach.Text = "";
            tacgia.Text = "";
            theloai.Text = "";
            dongia.Text = "";
        }
        public void Filltext()
        {
            DataSet dt = new DataSet();
            dt = bus.GoiYTimKiem();
            timkiem.DataSource = dt.Tables[0];
            timkiem.DisplayMember = "TenSach";
            timkiem.SelectedIndex = -1;
        }
        void ganDuLieu(Sach_DTO sach)
        {
            sach.MaSach = int.Parse(masach.Text.Trim());
            sach.MaNXB = int.Parse(manxb.Text.Trim());
            sach.TenSach = tensach.Text.Trim();
            sach.TacGia = tacgia.Text.Trim();
            sach.TheLoai = theloai.Text.Trim();
            sach.DonGia = double.Parse(dongia.Text.Trim());
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dtgsach.DataSource = bus.LoadDSSach();
        }
        int typeSearch = 0;

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            switch (typeSearch)
            {
                case 1:
                    {
                        dtgsach.DataSource = bus.Timmasach(int.Parse(timkiem.Text));
                        break;
                    }
                case 2:
                    {
                        dtgsach.DataSource = bus.Timtheotensach(timkiem.Text);
                        break;
                    }
                case 3:
                    {
                        dtgsach.DataSource = bus.Timtheloai(timkiem.Text);
                        break;
                    }
                case 4:
                    {
                        dtgsach.DataSource = bus.Timtacgia(timkiem.Text);
                        break;
                    }

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                typeSearch = 1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                typeSearch = 2;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                typeSearch = 3;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                typeSearch = 4;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            gruad = 0;
            khoaDK(true);
            clearKH();
            masach.Enabled = false;
            try
            {
                masach.Text = bus.LayMaSach();
            }
            catch
            {
                MessageBox.Show("Lấy mã sách không thành công!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            gruad = 1;
            khoaDK(true);
            masach.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            int index = e.RowIndex;
            DataGridViewRow row = dtgsach.SelectedRows[0];
            // Chuyển giá trị lên form
            masach.Text = row.Cells[0].Value.ToString();
            tensach.Text = row.Cells[2].Value.ToString();
            theloai.Text = row.Cells[4].Value.ToString();
            tacgia.Text = row.Cells[3].Value.ToString();
            manxb.Text = row.Cells[1].Value.ToString();
            dongia.Text = row.Cells[5].Value.ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (bus.KTMaNXB(int.Parse(manxb.Text)) == null)
            {
                MessageBox.Show("Mã NXB chưa tồn tại, vui lòng thêm NXB");
            }
            else
            {
                ganDuLieu(sach);
                if (gruad == 0)
                {
                    if (bus.ThemSach(sach) == true) { MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK); }
                    else { MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    if (bus.SuaSach(sach) == true)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                FormSach_Load(sender, e);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            FormSach_Load(sender, e);
        }
    }
}