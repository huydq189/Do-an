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
    public partial class FormHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        HoaDon_BUS busHD = new HoaDon_BUS();
        CTHD_BUS busCT = new CTHD_BUS();

        HoaDon_DTO HD = new HoaDon_DTO();
        CTHD_DTO CTHD = new CTHD_DTO();
        double NoToiDa;
        int SoLuongTonMin;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DateTime Time = DateTime.Now;
            txbNgayLap.Text = Time.ToString("dd/MM/yyyy");
            txbMaNV.Text = TTTaiKhoan.MaNV;
            try
            {
                Column1.DataSource = busCT.LayTTHang("");
            }
            catch
            {
                MessageBox.Show("Lấy thông tin hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Column1.ValueMember = "MaSach"; 
            Column1.DisplayMember = "MaSach"; 
            txbTongTien.Text = "0";
            try
            {
                SoLuongTonMin = int.Parse(busHD.LaySoLuong());
                NoToiDa = double.Parse(busHD.LayNoToiDa());
            }
            catch
            {
                MessageBox.Show("Lấy quy định không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                txbMaHD.Text = busHD.LayMaHD();                                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                cbMaKH.DataSource = busHD.LayMaKH();
                cbMaKH.ValueMember = "MaKH";
                cbMaKH.DisplayMember = "MaKH";
            }
            catch
            {
                MessageBox.Show("Lấy mã khách hàng không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCTHD.RowCount > 1) // số dòng lớn hơn 1 thì bắt đầu tính!
            {
                int dong = dtgCTHD.CurrentCell.RowIndex; //lấy index của dòng đang được chọn!

                if (dtgCTHD.Rows[dong].Cells[4].Value != null)
                {
                    double a = double.Parse(dtgCTHD.Rows[dong].Cells[4].Value.ToString()); // lấy giá trị thành tiền!
                    txbTongTien.Text = (double.Parse(txbTongTien.Text) + a).ToString();// tính tổng tiền của hóa đơn
                }

                if (dtgCTHD.Rows[dong].Cells[0].Value != null && dtgCTHD.Rows[dong].Cells[2].Value != null) // nếu có mã sách vs số lượng rồi thì mới tính thành tiền của sách
                {
                    if (dtgCTHD.Rows[dong].Cells[1].Value != null && dtgCTHD.Rows[dong].Cells[3].Value != null)
                    {
                        string MaSach = dtgCTHD.Rows[dong].Cells[0].Value.ToString();
                        string SoLuong = dtgCTHD.Rows[dong].Cells[2].Value.ToString();
                        int SoSachCon = int.Parse(busCT.LaySoLuongSach(MaSach));
                        string SoLuongMoi = (SoSachCon - int.Parse(SoLuong)).ToString();
                        if (int.Parse(SoLuongMoi) >= SoLuongTonMin)
                            dtgCTHD.Rows[dong].Cells[4].Value = double.Parse(dtgCTHD.Rows[dong].Cells[2].Value.ToString()) * double.Parse(dtgCTHD.Rows[dong].Cells[3].Value.ToString()) * 1.05;//tính thành tiền
                        else
                        {
                            MessageBox.Show("Số lượng sách sau khi bán còn ít hơn " + SoLuongTonMin + ", số lượng sách còn: " + SoSachCon + "", "Thông báo");
                            dtgCTHD.Rows[dong].Cells[2].Value = "0";
                            return;
                        }
                        for(int i = 0; i < dtgCTHD.RowCount - 1; i++)
                        {
                            if(MaSach == dtgCTHD.Rows[i].Cells[0].Value.ToString()&&(i!=dong))
                            {
                                MessageBox.Show("Mã sách không được giống nhau, vui lòn kiểm tra lại!");
                                return;
                            }
                        }
                    }

                }
                try
                {
                    if (dtgCTHD.Rows[dong].Cells[0].Value != null) //nếu có mã sách thì mới lấy ra tên sách vs số lượng
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = busCT.LayTTHang("WHERE MaSach = '" + int.Parse(dtgCTHD.Rows[dong].Cells[0].Value.ToString()) + " '");//lấy thông tin sách
                        dtgCTHD.Rows[dong].Cells[1].Value = dt1.Rows[0]["TenSach"].ToString();
                        dtgCTHD.Rows[dong].Cells[3].Value = double.Parse(dt1.Rows[0]["DonGia"].ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("Lấy thông tin sách không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int rc = dtgCTHD.RowCount;
            for (int i = 0; i < rc - 1; i++) // xóa hết dòng trong dtgrv
            {
                dtgCTHD.Rows.RemoveAt(0);
                //--rc;
            }
            txbSoTienThu.Text = "";
            txbTongTien.Text = "0";
            cbMaKH.Text = "";
            txbTienThua.Text = "";
            try
            {
                txbMaHD.Text = busHD.LayMaHD();// load lại mã hd
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {


                if (double.Parse(txbTongTien.Text) > 0 && dtgCTHD.Rows[dtgCTHD.CurrentCell.RowIndex].Cells[2].Value != null)
                {
                    txbTongTien.Text = (double.Parse(txbTongTien.Text) - double.Parse(dtgCTHD.Rows[dtgCTHD.CurrentCell.RowIndex].Cells[4].Value.ToString())).ToString();
                }
                dtgCTHD.Rows.RemoveAt(dtgCTHD.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Không thể xóa dòng! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); // xóa nhầm dòng mới
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            HD.MaHD = txbMaHD.Text;
            try
            {
                //string SoTienThu;
                if (cbKH.Checked) // kiểm tra xem có mã khách hàng hay ko?
                {
                    HD.MaKH = "1"; // có thì lưu mã kh(chưa lưu dc vì t chưa thêm khách hàng!)
                    if (double.Parse(txbTienThua.Text) < 0)
                    {
                        MessageBox.Show("Khách hàng chưa đăng ký thành viên không được mua thiếu!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    HD.SoTienNo = "0";
                    HD.SoTienThu = txbTongTien.Text;
                    HD.MaNV = txbMaNV.Text;
                    HD.NgHD = txbNgayLap.Text;
                    HD.TriGia = txbTongTien.Text;
                    if (!(busHD.LuuHoaDon(HD)))
                    {
                        MessageBox.Show("Lỗi khi lưu Hoadon!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    double NoMoi = 0;
                    HD.MaKH = cbMaKH.Text;
                    double tienNoHienTai = double.Parse(busHD.LayTienNoKH(HD.MaKH));
                    if (tienNoHienTai > NoToiDa)
                    {
                        MessageBox.Show("Không thể mua vì số tiền nợ của bạn(" + tienNoHienTai + ") lớn hơn nợ tối đa là (" + NoToiDa + ")!, vui lòng thanh toán trước khi mua hàng! ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (double.Parse(txbTienThua.Text) < 0)
                    {
                        double SoTienNo = double.Parse(txbTienThua.Text) * (-1);
                        NoMoi = tienNoHienTai + SoTienNo;
                        HD.SoTienThu = txbSoTienThu.Text;
                        HD.SoTienNo = SoTienNo.ToString();
                    }
                    else
                    {
                        HD.SoTienThu = txbTongTien.Text;
                        NoMoi = tienNoHienTai;
                        HD.SoTienNo = "0";
                    }
                    HD.MaNV = txbMaNV.Text;
                    HD.NgHD = txbNgayLap.Text;
                    HD.TriGia = txbTongTien.Text;
                    if (!busHD.LuuHoaDon(HD)) { MessageBox.Show("Lỗi khi lưu hóa đơn!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (!busHD.UpdateTienNo(HD.MaKH, NoMoi))
                    {
                        MessageBox.Show("Update tiền nợ không thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbMaHD.Text = busHD.LayMaHD().ToString();
                        return;
                    }
                }
                    try
                    {
                        for (int i = 0; i < dtgCTHD.RowCount - 1; i++) //lưu CTHD và lưu số lượng mới của sách
                        {
                            string MaSach = dtgCTHD.Rows[i].Cells[0].Value.ToString();
                            string SoLuong = dtgCTHD.Rows[i].Cells[2].Value.ToString();
                            string SoLuongMoi = (int.Parse(busCT.LaySoLuongSach(MaSach)) - int.Parse(SoLuong)).ToString();
                            CTHD.MaSach = MaSach;
                            CTHD.SoLuong = SoLuong;
                            CTHD.MaHD = txbMaHD.Text;
                            if (!busCT.LuuCT(CTHD))
                            {
                                MessageBox.Show("Lỗi khi lưu cthd!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (!busCT.UpdateSoLuongSach(MaSach, SoLuongMoi)) //update số lượng mới!
                            {
                                MessageBox.Show("Lỗi khi update số lượng!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("Thanh toán thành công!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbMaHD.Text = busHD.LayMaHD();

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi khi lưu CTHD", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbMaHD.Text = busHD.LayMaHD();
                    }
                }
            catch
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn");
            }
        }

        private void txbSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txbSoTienThu.Text != "" && txbTongTien.Text != "")
            { // bắt lỗi nhập chữ
                try
                {
                    txbTienThua.Text = (double.Parse(txbSoTienThu.Text) - double.Parse(txbTongTien.Text)).ToString();
                    simpleButton4.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số ");
                }
            }
        }

        private void cbKH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKH.Checked)
            {
                cbMaKH.Enabled = false;
                cbMaKH.Text = "2";
            }
            else
                cbMaKH.Enabled = true;
        }
    }
}