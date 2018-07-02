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
            load();
        }
        QuyDinh_BUS qd = new QuyDinh_BUS();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = qd.showQD();
            dtgvQD.DataSource = dt;
            DatTen();
        }
        public void DatTen()
        {
            dtgvQD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvQD.Columns[0].HeaderText = "ID";
            dtgvQD.Columns[0].Width = 100;
            dtgvQD.Columns[0].Frozen = true;

            dtgvQD.Columns[1].HeaderText = "Tồn tối thiểu trước nhập";
            dtgvQD.Columns[1].Width = 75;

            dtgvQD.Columns[2].HeaderText = "Số lượng nhập ít nhất";
            dtgvQD.Columns[2].Width = 75;

            dtgvQD.Columns[3].HeaderText = "Nợ tối đa";
            dtgvQD.Columns[3].Width = 75;

            dtgvQD.Columns[4].HeaderText = "Tồn tối thiểu sau bán";
            dtgvQD.Columns[4].Width = 75;

            dtgvQD.Columns[5].HeaderText = "Quyết định thu tiền";
            dtgvQD.Columns[5].Width = 95;
        }
        public void reset()
        {
            txtID.Text = "";
            txtTTT.Text = "";
            txtSLN.Text = "";
            txtNTD.Text = "";
            txtTTTs.Text = "";
        }

     
        string quydinh = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QuyDinh_DTO quyd = new QuyDinh_DTO();
                quyd.ID = int.Parse(txtID.Text);
                quyd.TonToiThieu = int.Parse(txtTTT.Text);
                quyd.SoLuongItNhat = int.Parse(txtSLN.Text);
                quyd.NoToiDa = double.Parse(txtNTD.Text);
                quyd.Ttts = int.Parse(txtTTTs.Text);
                if (cbQDTT.Checked == true)
                {
                    quydinh = "True";
                }
                else
                {
                    quydinh = "False";
                }


                qd.ThayDoi(quyd.TonToiThieu, quyd.SoLuongItNhat, quyd.NoToiDa, quyd.Ttts, quydinh);
                load();
                MessageBox.Show("Thay đổi thành công");
                reset();

            }
            catch (Exception)
            {
                MessageBox.Show("Thay đổi không được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        

        }

        private void dtgvQD_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtID.Text = dtgvQD.Rows[dong].Cells[0].Value.ToString();
            this.txtTTT.Text = dtgvQD.Rows[dong].Cells[1].Value.ToString();
            this.txtSLN.Text = dtgvQD.Rows[dong].Cells[2].Value.ToString();
            this.txtNTD.Text = dtgvQD.Rows[dong].Cells[3].Value.ToString();
            this.txtTTTs.Text = dtgvQD.Rows[dong].Cells[4].Value.ToString();
        }
    }
}
