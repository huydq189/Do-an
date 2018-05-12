using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOADON_BUS;
using HOADON_DTO;

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
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            txbDT.Text = Time.ToString("dd/MM/yyyy");
            Column1.DataSource = busCT.LayTTHang("");
            Column1.ValueMember = "MaSach"; // giá trị của column 1 trong dtgr là mã sách
            Column1.DisplayMember = "MaSach"; //hiển thị ra ngoài cũng là mã sách
            textBox11.Text = "0";
            try  // lấy mã hd của hd này! gán vào txb mã hd bằng cách lấy mã hd lớn nhất trong db + 1 vì mã hd hay mã kh, mã pt, pn .... T đều cho tự tăng,
            {//                                                                                                                          có giá trị ban đầu là 1
                textBox2.Text = busHD.LayMaHD(); //                                                     và mỗi lần thêm mới vô thì tăng 1 đơn vị!
            }    
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dong = e.RowIndex;  code này chỉ lấy dc index của dòng mà mình click vào thôi, còn chuyển dòng bằng phím tab thì nó ko bắt dc nên bỏ
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView1.RowCount>1) // số dòng lớn hơn 1 thì bắt đầu tính!
                {
                    int dong = dataGridView1.CurrentCell.RowIndex; //lấy index của dòng đang được chọn!
                    try
                    {
                        if (dataGridView1.Rows[dong].Cells[4].Value != null) //kiểm thành tiền có null hay ko, nếu null sẽ bị lỗi khi truy cập vào hàm ToString()
                        {
                            double a = double.Parse(dataGridView1.Rows[dong].Cells[4].Value.ToString()); // lấy giá trị thành tiền!
                            textBox11.Text = (double.Parse(textBox11.Text) + a).ToString();// tính tổng tiền của hóa đơn

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    try
                    {
                        if (dataGridView1.Rows[dong].Cells[0].Value != null) //nếu có mã sách thì mới lấy ra tên sách vs số lượng
                        {
                            DataTable dt1 = new DataTable();
                            dt1 = busCT.LayTTHang("WHERE MaSach = '" + int.Parse(dataGridView1.Rows[dong].Cells[0].Value.ToString()) + " '");//lấy thông tin sách
                            dataGridView1.Rows[dong].Cells[1].Value = dt1.Rows[0]["TenSach"].ToString();
                            dataGridView1.Rows[dong].Cells[3].Value = double.Parse(dt1.Rows[0]["DonGia"].ToString());
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    try
                    {
                        if (dataGridView1.Rows[dong].Cells[0].Value != null && dataGridView1.Rows[dong].Cells[2].Value != null) // nếu có mã sách vs số lượng rồi thì mới tính thành tiền của sách
                        {
                            dataGridView1.Rows[dong].Cells[4].Value = double.Parse(dataGridView1.Rows[dong].Cells[2].Value.ToString()) * double.Parse(dataGridView1.Rows[dong].Cells[3].Value.ToString()) * 1.05;//tính thành tiền
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show("đm không dc xóa dòng này >_<!", "Thông cmn báo",MessageBoxButtons.OK,MessageBoxIcon.Warning); // xóa nhầm dòng mới
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    MessageBox.Show("Nhập số thôi m ! -_-! ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // btn lưu hd
        {
            if (textBox4.Text != "") // kiểm tra xem có mã khách hàng hay ko?
                HD.MaKH = textBox4.Text; // có thì lưu mã kh(chưa lưu dc vì t chưa thêm khách hàng!) 
            else
                HD.MaKH = "1"; //không có mã kh thì lưu vô 1 kh dc tạo sẵn trong db, kh này t tạo có mã kh là 1 
            HD.MaNV = "1"; // mã nhân viên vì chưa có chức năng login để lấy mã nv nên t tạo auto cho bằng 1
            HD.NgHD = txbDT.Text;
            HD.TriGia = textBox11.Text;
            try { busHD.LuuHoaDon(HD); }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            try
            {
                for(int i =0; i < dataGridView1.RowCount - 1; i++) //lưu CTHD và lưu số lượng mới của sách
                {
                    string MaSach = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string SoLuong = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string SoLuongMoi = (int.Parse(busCT.LaySoLuongSach(MaSach))-int.Parse(SoLuong)).ToString();
                    CTHD.MaSach = MaSach;
                    CTHD.SoLuong = SoLuong;
                    CTHD.MaHD = textBox2.Text;
                    busCT.LuuCT(CTHD);
                    busCT.UpdateSoLuongSach(MaSach, SoLuongMoi); //update số lượng mới!
                }
                MessageBox.Show("Thanh toán thành công!");
                button5_Click(sender, e);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // FormHoaDon // chưa biết làm :V
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
