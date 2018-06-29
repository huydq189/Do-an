using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS
{
    public partial class formQuyDinh : Form
    {
        public formQuyDinh()
        {
            InitializeComponent();
        }

        private void formQuyDinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        QuyDinh_BUS qd = new QuyDinh_BUS();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = qd.showQD();
            dtgvQD.DataSource = dt;
            DatTen();
        }
        public void DatTen()
        {
            dtgvQD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvQD.Columns[0].HeaderText = "Tồn tối thiểu trước nhập";
            dtgvQD.Columns[0].Width = 125;
            dtgvQD.Columns[0].Frozen = true;

            dtgvQD.Columns[1].HeaderText = "Số lượng nhập ít nhất";
            dtgvQD.Columns[1].Width = 125;

            dtgvQD.Columns[2].HeaderText = "Nợ tối đa";
            dtgvQD.Columns[2].Width = 125;

            dtgvQD.Columns[3].HeaderText = "Tồn tối thiểu sau bán";
            dtgvQD.Columns[3].Width = 125;
        }
        public void reset()
        {
            txtTTT.Text = "";
            txtSLN.Text = "";
            txtNTD.Text = "";
            txtTTTs.Text = "";
        }

        private void dtgvQD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtTTT.Text = dtgvQD.Rows[dong].Cells[0].Value.ToString();
            this.txtSLN.Text = dtgvQD.Rows[dong].Cells[1].Value.ToString();
            this.txtNTD.Text = dtgvQD.Rows[dong].Cells[2].Value.ToString();
            this.txtTTTs.Text = dtgvQD.Rows[dong].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QuyDinh_DTO quyd = new QuyDinh_DTO();
                quyd.TonToiThieu = int.Parse(txtTTT.Text);
                quyd.SoLuongItNhat = int.Parse(txtSLN.Text);
                quyd.NoToiDa = double.Parse(txtNTD.Text);
                quyd.Ttts = int.Parse(txtTTTs.Text);
                qd.ThayDoi(quyd);
                reset();
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Thay đổi không được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
    }
}
