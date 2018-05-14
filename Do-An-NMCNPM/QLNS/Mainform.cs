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

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    if (f.Name == "FormHoaDon")
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
    }
    public static class TTTaiKhoan
    {
        public static string MaNV = null;
        public static string ChucVu = null;
    }
}
