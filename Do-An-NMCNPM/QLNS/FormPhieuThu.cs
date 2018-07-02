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
using DAL;
using DTO;
using BUS;

namespace QLNS
{
    public partial class FormPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuThu()
        {
            InitializeComponent();
        }
        PhieuThu_BUS pt = new PhieuThu_BUS();
        string quydinh = null;
        double tienno = 0;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuThu_DTO pht = new PhieuThu_DTO();
                pht.MaKH = int.Parse(txtMaKH.Text);
                pht.MaNV = int.Parse(txtMaNV.Text);
                pht.MaPT = int.Parse(txtMaPT.Text);
                pht.NgayThu = DateTime.Parse(txtNgayThu.Text);
                pht.SoTienThu = double.Parse(txtSoTienThu.Text);
                tienno = double.Parse(pt.Laysotien(pht));

                if (quydinh == "True")
                {
                    
                        double StnM = 0;

                        if (pht.SoTienThu > tienno)
                        {
                            MessageBox.Show("Sai quy định, số tiền thu không được lớn hơn số tiền nợ");

                        }
                        else if (pht.SoTienThu <= tienno)
                        {
                            StnM = tienno - pht.SoTienThu;                           
                            pt.UpDateSTN(StnM, pht.MaKH);
                            pt.insertPT(pht);
                            load();
                        }
                  
                   
                }
                else { 

                            double StnM = tienno - pht.SoTienThu;                           
                            pt.UpDateSTN(StnM, pht.MaKH);
                            pt.insertPT(pht);
                            load();
                  
                   
                }
                MessageBox.Show("Thêm thành công");
                reset();

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }

        }
        public void load()
        {
            DataTable dt = new DataTable();
            dt = pt.showPT();
            dtgvPT.DataSource = dt;

            DatTen();
        }
        public void DatTen()
        {
            dtgvPT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPT.Columns[0].HeaderText = "Mã phiếu thu";
            dtgvPT.Columns[0].Width = 125;
            dtgvPT.Columns[0].Frozen = true;

            dtgvPT.Columns[1].HeaderText = "Mã khách hàng";
            dtgvPT.Columns[1].Width = 125;

            dtgvPT.Columns[2].HeaderText = "Ngày thu";
            dtgvPT.Columns[2].Width = 125;

            dtgvPT.Columns[3].HeaderText = "Mã nhân viên";
            dtgvPT.Columns[3].Width = 125;

            dtgvPT.Columns[4].HeaderText = "Số tiền thu";
            dtgvPT.Columns[4].Width = 160;
        }
        public void reset()
        {
            txtMaPT.Text = "";
            txtMaKH.Text = "";
            txtNgayThu.Text = "";
            txtMaNV.Text = "";
            txtSoTienThu.Text = "";
        }
        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            quydinh = pt.Layquydinh();
            txtMaNV.Text = TTTaiKhoan.MaNV;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void dtgvPT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            this.txtMaPT.Text = dtgvPT.Rows[dong].Cells[0].Value.ToString();
            this.txtMaKH.Text = dtgvPT.Rows[dong].Cells[1].Value.ToString();
            this.txtNgayThu.Text = dtgvPT.Rows[dong].Cells[2].Value.ToString();
            this.txtMaNV.Text = dtgvPT.Rows[dong].Cells[3].Value.ToString();
            this.txtSoTienThu.Text = dtgvPT.Rows[dong].Cells[4].Value.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}