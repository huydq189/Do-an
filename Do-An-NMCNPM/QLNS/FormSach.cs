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
    }
}