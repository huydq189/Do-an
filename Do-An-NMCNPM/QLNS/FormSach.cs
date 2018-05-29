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
        Sach_DTO et = new Sach_DTO();
        public FormSach()
        {
            InitializeComponent();
        }
        private void FormSach_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.LoadDSSach();
        }
        int typeSearch = 0;

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            switch (typeSearch)
            {
                case 1:
                    {
                        dataGridView1.DataSource = bus.Timmasach(int.Parse(textBox1.Text));
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = bus.Timtheotensach(textBox1.Text);
                        break;
                    }
                case 3:
                    {
                        dataGridView1.DataSource = bus.Timtheloai(textBox1.Text);
                        break;
                    }
                case 4:
                    {
                        dataGridView1.DataSource = bus.Timtacgia(textBox1.Text);
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //xóa sách  đc chon; 
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                et.MaSach = Convert.ToInt32(row.Cells[0].Value.ToString());
                bus.XoaSach(et);
                simpleButton5.PerformClick();
                MessageBox.Show("Xóa thành công ");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                et.MaSach = Convert.ToInt32(textBox6.Text);
                et.TenSach = textBox2.Text;
                et.TheLoai = textBox3.Text;
                et.TacGia = textBox4.Text;
                et.MaNXB = Convert.ToInt32(textBox7.Text);
                et.DonGia = Convert.ToInt32(textBox5.Text);
                et.SoLuong = 0;
                bus.ThemSach(et);
                DataTable a = new DataTable();
                a = bus.LoadDSSach();
                dataGridView1.DataSource = a.AsDataView();
                MessageBox.Show(et.TheLoai);
                MessageBox.Show(et.TacGia);
                MessageBox.Show(Convert.ToString(et.DonGia));
                MessageBox.Show(et.TenSach);
                MessageBox.Show(Convert.ToString(et.MaNXB));


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                et.MaSach = Convert.ToInt32(textBox6.Text);
                et.TenSach = textBox2.Text;
                et.TacGia = textBox4.Text;
                et.TheLoai = textBox3.Text;
                et.DonGia = double.Parse(textBox5.Text);

                bus.SuaSach(et);
                bus.LoadDSSach();
            }
            catch { MessageBox.Show("loi"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            // Chuyển giá trị lên form
            textBox6.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox7.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
        }
    }
}