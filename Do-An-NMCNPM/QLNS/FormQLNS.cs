using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormQLNS : Form
    {
        public FormQLNS()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSach fs = new FormSach();
            fs.ShowDialog();
        }

        private void lậpPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuNhap pn = new FormPhieuNhap();
            pn.ShowDialog();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void lậpPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuThu pt = new FormPhieuThu();
            pt.ShowDialog();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoTon bct = new FormBaoCaoTon();
            bct.ShowDialog();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoCongNo bccn = new FormBaoCaoCongNo();
            bccn.ShowDialog();
        }

        private void FormQLNS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = FormQLNS.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "FormHoaDon")
                {
                    f.Activate();
                    return;
                }
            }


            FormHoaDon frm1 = new FormHoaDon();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }
    }
    public static class TTTaiKhoan
    {
        public static string MaNV = null;
        public static string ChucVu = null;
    }
}
