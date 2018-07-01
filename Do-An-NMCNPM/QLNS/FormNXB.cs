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
    public partial class FormNXB : DevExpress.XtraEditors.XtraForm
    {
        NXB_BUS bus = new NXB_BUS();
        NXB_DTO nxb = new NXB_DTO();
        int gruad = 0;
        public FormNXB()
        {
            InitializeComponent();
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataTable dtnxb = new DataTable();
            dtnxb = bus.HTNXB();
            dtgDSNXB.DataSource = dtnxb;
            bingding();
            khoaDK(false);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        void bingding()
        {
            txbmanxb.DataBindings.Clear();
            txbmanxb.DataBindings.Add("Text", dtgDSNXB.DataSource, "MaNXB");
            txbtennxb.DataBindings.Clear();
            txbtennxb.DataBindings.Add("Text", dtgDSNXB.DataSource, "TenNXB");
            txbdiachi.DataBindings.Clear();
            txbdiachi.DataBindings.Add("Text", dtgDSNXB.DataSource, "DiaChi");
            txbSDT.DataBindings.Clear();
            txbSDT.DataBindings.Add("Text", dtgDSNXB.DataSource, "SDT");
        }
        void khoaDK(bool a)
        {
            txbmanxb.Enabled = a;
            txbtennxb.Enabled = a;
            txbdiachi.Enabled = a;
            txbSDT.Enabled = a;
        }
        void clearKH()
        {
            txbmanxb.Text = "";
            txbtennxb.Text = "";
            txbdiachi.Text = "";
            txbSDT.Text = "";
        }
        void ganDuLieu(NXB_DTO nxb)
        {
            nxb.MaNXB = int.Parse(txbmanxb.Text.Trim());
            nxb.TenNXB = txbtennxb.Text.Trim();
            nxb.Diachi = txbdiachi.Text.Trim();
            nxb.Sdt = txbSDT.Text.Trim();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            gruad = 0;
            khoaDK(true);
            clearKH();
            txbmanxb.Enabled = false;
            try
            {
                txbmanxb.Text = bus.LayMaNXB();
            }
            catch
            {
                MessageBox.Show("Lấy mã nxb không thành công!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nxb);
            if (gruad == 0)
            {
                if (bus.ThemNXB(nxb)) { MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK); }
                else { MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            {
                if (bus.SuaNXB(nxb))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            FormNXB_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormNXB_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgDSNXB.DataSource = bus.TimNXB(int.Parse(txbSearch.Text));
            bingding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            gruad = 1;
            khoaDK(true);
            txbmanxb.Enabled = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chăc muốn xóa?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                ganDuLieu(nxb);
                try
                {
                    if (bus.XoaNXB(nxb) == true)
                    {
                        MessageBox.Show("Xóa thành công ");
                        FormNXB_Load(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
                return;

        }
    }
}