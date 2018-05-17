using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Sach_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        //Load danh sach tat ca sach
        public DataTable LoadDSTatCaSach()
        {
            return cn.GetTable("SELECT * FROM SACH");
        }

        /*Them sach
        public static void ThemSach(Sach_DTO sach)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_THEMSACH", cnn);
            cmd.Parameters.Add("@MaNXB", SqlDbType.Int);
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 70);
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 70);
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@DonGia", SqlDbType.Money);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
            cmd.Parameters["@MaNXB"].Value = sach.MaNXB;
            cmd.Parameters["@TenSach"].Value = sach.TenSach;
            cmd.Parameters["@TacGia"].Value = sach.TacGia;
            cmd.Parameters["@TheLoai"].Value = sach.TheLoai;
            cmd.Parameters["@DonGia"].Value = sach.DonGia;
            cmd.Parameters["@SoLuong"].Value = sach.SoLuong;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        //Xoa sach theo Masach
        public static void XoaSach(int MaSach)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_XOASACH", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Int);
            cmd.Parameters["@MaSach"].Value = MaSach;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        //Tim sach the loai
        public static DataTable Timtheotheloai(string Theloai)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_TIMSACHTHELOAI", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TheLoai", SqlDbType.NVarChar, 100);
            cmd.Parameters["@TheLoai"].Value = Theloai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //Tim sach theo tac gia
        public static DataTable Timtheotacgia(string TenTacGia)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_TIMSACHTACGIA", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar, 70);
            cmd.Parameters["@TacGia"].Value = TenTacGia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //Tim sach theo ten sach
        public static DataTable TimTheotensach(string TenSach)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_TIMSACHTENSACH", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar, 70);
            cmd.Parameters["@TenSach"].Value = TenSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        //Tim sach ma sach
        public static DataTable Timtheomasach(int MaSach)
        {
            SqlConnection cnn = sqlConnectionData.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SP_TIMSACHMASACH", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.Int);
            cmd.Parameters["@MaSach"].Value = MaSach;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }*/
    }
}