using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class Mainform : DevExpress.XtraEditors.XtraForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormHoaDon")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormHoaDon frm1 = new FormHoaDon();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormXemHD")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormXemHD frm1 = new FormXemHD();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormSach")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormSach frm1 = new FormSach();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormPhieuThu")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormPhieuThu frm1 = new FormPhieuThu();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormPhieuNhap")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormPhieuNhap frm1 = new FormPhieuNhap();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "frmKhachHang")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            frmKhachHang frm1 = new frmKhachHang();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "BCTon")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            BCTon frm1 = new BCTon();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "BCNo")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            BCNo frm1 = new BCNo();
            frm1.MdiParent = this;
            //Closeform("frmQLSV");
            frm1.Show();
            frm1.Top = 0;
            frm1.Left = 0;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Mainform.ActiveForm;
            if (frm != null)
            {
                foreach (Form f in frm.MdiChildren)
                {
                    if (f.Name == "FormNXB")
                    {
                        f.Activate();
                        return;
                    }
                }
            }


            FormNXB frm1 = new FormNXB();
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
