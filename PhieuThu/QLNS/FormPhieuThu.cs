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
using DAO;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class FormPhieuThu : Form
    {
        public FormPhieuThu()
        {
            InitializeComponent();
        }

        BUS_PT pt = new BUS_PT();
        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            txtNgayPT.Text = Time.ToString("dd/MM/yyyy");
            load();
            DatTen();
        }
        public void ResetPT()
        {
            txtMaPT.Text = "";
            txtNgayThuPT.Text = "";
            txtSotienthuPT.Text = "";
        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = pt.showPT();
            dtgvPT.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetPT();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DatTen()
        {
            dtgvPT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPT.Columns[0].HeaderText = "Mã phiếu thu";
            dtgvPT.Columns[0].Width = 150;
            dtgvPT.Columns[0].Frozen = true;

            dtgvPT.Columns[1].HeaderText = "Ngày thu";
            dtgvPT.Columns[1].Width = 150;

            dtgvPT.Columns[2].HeaderText = "Số tiền thu";
            dtgvPT.Columns[2].Width = 150;
        }

        int dong;
        private void dtgvPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            this.txtMaPT.Text = dtgvPT.Rows[dong].Cells[0].Value.ToString();
            this.txtNgayThuPT.Text = dtgvPT.Rows[dong].Cells[1].Value.ToString();
            this.txtSotienthuPT.Text = dtgvPT.Rows[dong].Cells[2].Value.ToString();
        }
        string them;
        private void button2_Click(object sender, EventArgs e)
        {
            //mã tự sinh
            int count = 0;
            count = dtgvPT.Rows.Count;
            string chuoi = "";
            int chuoi1 = 0;
            chuoi = Convert.ToString(dtgvPT.Rows[count - 2].Cells[0].Value);
            chuoi1 = Convert.ToInt32((chuoi.Remove(0, 2)));//Loai bỏ ký tự PT (nếu có) cái này chắc không cần vì mã toàn số;
            if (chuoi1 + 1 < 10)
                txtMaPT.Text = "000" + (chuoi1 + 1).ToString();//cho nó có nhiều số 0 để khác biệt với mã khác, hoặc thêm chữ PT cũng đc
            else if(chuoi1+1<100)
                txtMaPT.Text = "00" + (chuoi1 + 1).ToString();
            //Thêm pt;
            try
            {
                DAO_PT.Insert(new DTO_PT(txtMaPT.Text, txtNgayThuPT.Text, txtSotienthuPT.Text));
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        //DAO_PT là KetNoiDB do mình đặt tên nhầm, giờ sửa khá mất thời gian...mình làm thử combobox không dùng 3 lớp
        DAO_PT ut = new DAO_PT();
      
        public void showCombobox()
        {
            SqlConnection conn = ut.MoKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenNV from NHANVIEN", conn);
            SqlDataAdapter da=new SqlDataAdapter();
            da.SelectCommand=cmd;
            DataTable tb=new DataTable();
            da.Fill(tb);
            cbbNV.DataSource=tb;
            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";

        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showCombobox();
        }

      



    }
}
