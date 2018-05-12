using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace QLNS
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        HoaDon_BUS busHD = new HoaDon_BUS();
        CTHD_BUS busCT = new CTHD_BUS();

        HoaDon_DTO HD = new HoaDon_DTO();
        CTHD_DTO CTHD = new CTHD_DTO();
        double NoToiDa;
        int SoLuongTonMin;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            textBox1.Text = TTTaiKhoan.MaNV;
            DateTime Time = DateTime.Now;
            txbDT.Text = Time.ToString("dd/MM/yyyy");
            try
            {
                Column1.DataSource = busCT.LayTTHang("");
            }
            catch
            {
                MessageBox.Show("Lấy thông tin hàng không thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Column1.ValueMember = "MaSach"; // giá trị của column 1 trong dtgr là mã sách
            Column1.DisplayMember = "MaSach"; //hiển thị ra ngoài cũng là mã sách
            textBox11.Text = "0";
            try
            {
                SoLuongTonMin = int.Parse(busHD.LaySoLuong());
                NoToiDa = double.Parse(busHD.LayNoToiDa());
            }
            catch
            {
                MessageBox.Show("Lấy quy định không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try  // lấy mã hd của hd này! gán vào txb mã hd bằng cách lấy mã hd lớn nhất trong db + 1 
            {
                textBox2.Text = busHD.LayMaHD();
            }    
            catch
            {
                MessageBox.Show("Lấy mã hóa đơn không thành công! ","Thông báo! ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //int dong1 = e.RowIndex;  
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

                if (dataGridView1.RowCount>1) // số dòng lớn hơn 1 thì bắt đầu tính!
                {
                    int dong = dataGridView1.CurrentCell.RowIndex; //lấy index của dòng đang được chọn!

                        if (dataGridView1.Rows[dong].Cells[4].Value != null) //kiểm thành tiền có null hay ko
                        {
                            double a = double.Parse(dataGridView1.Rows[dong].Cells[4].Value.ToString()); // lấy giá trị thành tiền!
                            textBox11.Text = (double.Parse(textBox11.Text) + a).ToString();// tính tổng tiền của hóa đơn

                        }



                if (dataGridView1.Rows[dong].Cells[0].Value != null && dataGridView1.Rows[dong].Cells[2].Value != null) // nếu có mã sách vs số lượng rồi thì mới tính thành tiền của sách
                {
                    if (dataGridView1.Rows[dong].Cells[1].Value != null && dataGridView1.Rows[dong].Cells[3].Value != null)
                    {
                        string MaSach = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                        string SoLuong = dataGridView1.Rows[dong].Cells[2].Value.ToString();
                        int SoSachCon = int.Parse(busCT.LaySoLuongSach(MaSach));
                        string SoLuongMoi = (SoSachCon - int.Parse(SoLuong)).ToString();
                        if (int.Parse(SoLuongMoi) >= SoLuongTonMin)
                            dataGridView1.Rows[dong].Cells[4].Value = double.Parse(dataGridView1.Rows[dong].Cells[2].Value.ToString()) * double.Parse(dataGridView1.Rows[dong].Cells[3].Value.ToString()) * 1.05;//tính thành tiền
                        else
                        {
                            MessageBox.Show("Số lượng sách sau khi bán còn ít hơn " + SoLuongTonMin + ", số lượng sách còn: " + SoSachCon + "", "Thông báo");
                            return;
                        }
                    }
                }
                    try
                    {
                        if (dataGridView1.Rows[dong].Cells[0].Value != null) //nếu có mã sách thì mới lấy ra tên sách vs don gia
                        {
                            DataTable dt1 = new DataTable();
                            dt1 = busCT.LayTTHang("WHERE MaSach = '" + int.Parse(dataGridView1.Rows[dong].Cells[0].Value.ToString()) + " '");//lấy thông tin sách
                            dataGridView1.Rows[dong].Cells[1].Value = dt1.Rows[0]["TenSach"].ToString();
                            dataGridView1.Rows[dong].Cells[3].Value = double.Parse(dt1.Rows[0]["DonGia"].ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lấy thông tin sách không thành công!", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }


                }


        }

        private void button8_Click(object sender, EventArgs e) //btn xóa 1 dòng được chọn
        {
            try
            {


                    if (double.Parse(textBox11.Text) > 0 && dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value != null)
                    {
                        textBox11.Text = (double.Parse(textBox11.Text) - double.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString())).ToString();
                    }
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Không thể xóa dòng!", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error); // xóa nhầm dòng mới
            }
        }

        private void button5_Click(object sender, EventArgs e) // btn hóa đơn mới
        {
                int rc = dataGridView1.RowCount;
                for (int i = 0; i < rc - 1; i++) // xóa hết dòng trong dtgrv
                {
                    dataGridView1.Rows.RemoveAt(0);
                    //--rc;
                }
            textBox12.Text = "";
            textBox11.Text = "";
            textBox11.Text = "0";
            textBox4.Text = "";
            textBox13.Text = "";
            try
            {
                textBox2.Text = busHD.LayMaHD();// load lại mã hd
            }
            catch
            {
                MessageBox.Show("Lấy mã hóa đơn không thành công!", "Thông báo! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void textBox12_TextChanged(object sender, EventArgs e)//txb số tiền khách đưa
        {
            if (textBox12.Text!="" && textBox11.Text!="" ) { // bắt lỗi nhập chữ
                try
                {
                    textBox13.Text = (double.Parse(textBox12.Text) - double.Parse(textBox11.Text)).ToString();
                    button4.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số! ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // btn lưu hd
        {
            double tiennomoi = 0;
            if (textBox4.Text != "") // kiểm tra xem có mã khách hàng hay ko?
            {
                if (busHD.KiemTraMaKH(textBox4.Text))
                {
                    HD.MaKH = textBox4.Text; // có thì lưu mã kh(chưa lưu dc vì t chưa thêm khách hàng!)
                    double TienNo = 0;
                    try
                    {
                        TienNo = double.Parse(busHD.LayTienNoKH(HD.MaKH));
                    }
                    catch
                    {
                        MessageBox.Show("Lấy tiền nợ không thành công!");
                        return;
                    }
                    if (TienNo > NoToiDa)
                    {
                        MessageBox.Show("Số tiền nợ tối đa là " + NoToiDa + ", khách hàng đang nợ " + TienNo + "", "Lỗi! ", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        return;
                    }
                    if (double.Parse(textBox13.Text) < 0)
                    {
                        tiennomoi = TienNo + (-1) * double.Parse(textBox13.Text);
                        double b = double.Parse(textBox11.Text) + double.Parse(textBox13.Text);
                        if (tiennomoi <= NoToiDa)
                        {
                            HD.TriGia = b.ToString();
                            HD.MaNV = textBox1.Text; // mã nhân viên vì chưa có chức năng login để lấy mã nv nên t tạo auto cho bằng 1
                            HD.NgHD = txbDT.Text;
                            if (!busHD.LuuHoaDon(HD))
                            {
                                MessageBox.Show("Lưu hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                busHD.UpdateTienNo(textBox4.Text, tiennomoi);
                                MessageBox.Show("Luu hoa don thanh cong!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Số tiền nợ tối đa là " + NoToiDa + ", khách hàng đang nợ " + TienNo + "", "Lỗi! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        HD.TriGia = textBox11.Text;
                        HD.MaNV = textBox1.Text; // mã nhân viên vì chưa có chức năng login để lấy mã nv nên t tạo auto cho bằng 1
                        HD.NgHD = txbDT.Text;
                        if (!busHD.LuuHoaDon(HD))
                        {
                            MessageBox.Show("Lưu hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else MessageBox.Show("Luu hoa don thanh cong!");
                    }

                }
                else
                {
                    MessageBox.Show("Nhap sai mã khách hàng, vui lòng nhập lại!");
                    return;
                }
            }
            else {
                HD.TriGia = textBox11.Text;
                if (double.Parse(textBox13.Text) < 0)
                {
                    MessageBox.Show("Khach hang chu dang ky thanh vien khong the mua thieu");
                    return;
                }
                HD.MaKH = "1"; //không có mã kh thì lưu vô 1 kh dc tạo sẵn trong db, kh này t tạo có mã kh là 1 
                HD.MaNV = textBox1.Text; 
                HD.NgHD = txbDT.Text;
                if (!busHD.LuuHoaDon(HD))
                {
                    MessageBox.Show("Lưu hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = busHD.LayMaHD();
                    return;
                }
                else MessageBox.Show("Luu hoa don thanh cong!");
            }

                for (int i = 0; i < dataGridView1.RowCount - 1; i++) //lưu CTHD và lưu số lượng mới của sách
                {
                    string MaSach = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string SoLuong = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string SoLuongMoi = (int.Parse(busCT.LaySoLuongSach(MaSach)) - int.Parse(SoLuong)).ToString();
                    CTHD.MaSach = MaSach;
                    CTHD.SoLuong = SoLuong;
                    CTHD.MaHD = textBox2.Text;
                    if (!busCT.LuuCT(CTHD))
                    {
                        MessageBox.Show("Lỗi khi lưu CTHD!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    busHD.UpdateHoaDonLoi(CTHD.MaHD);
                    textBox2.Text = busHD.LayMaHD();
                    return;
                    }
                    if (!busCT.UpdateSoLuongSach(MaSach, SoLuongMoi)) //update số lượng mới!
                    {
                        MessageBox.Show("Không update được số lượng sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    busHD.UpdateHoaDonLoi(CTHD.MaHD);
                    textBox2.Text = busHD.LayMaHD();
                    return;
                        
                    }
                }
                MessageBox.Show("Thanh toán thành công!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
<<<<<<< HEAD
        }*/
=======
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> fee372bd8daca9f5a95557424c3cc80657a8ddd5
    }
}
