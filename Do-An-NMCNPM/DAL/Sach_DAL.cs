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
        //Tim sach the loai
        public DataTable Timtheotheloai(string Theloai)
        {
            return cn.GetTable("SELECT * FROM SACH WHERE TheLoai =N'" + Theloai + "'");
        }
        //Tim sach theo tac gia
        public DataTable Timtheotacgia(string TenTacGia)
        {
            return cn.GetTable("SELECT * FROM SACH WHERE TacGia = N'" + TenTacGia + "'");
        }
        //Tim sach theo ten sach
        public DataTable TimTheotensach(string TenSach)
        {
            return cn.GetTable("SELECT * FROM SACH WHERE TenSach = N'" + TenSach + "'");
        }
        //Tim sach ma sach
        public DataTable Timtheomasach(int MaSach)
        {
            return cn.GetTable("SELECT * FROM SACH WHERE MaSach = '" + MaSach + "'");
        }
        //Sua sach
        public bool Suasach(Sach_DTO et)
        {
            return cn.ExcuteNoneQuery("UPDATE SACH set  TenSach = N'" + et.TenSach + "', TacGia = N'" + et.TacGia + "', TheLoai = N'" + et.TheLoai + "', DonGia = '" + et.DonGia + "' where MaSach = '" + et.MaSach + "'");
        }
        //Them sach
        public bool Themsach(Sach_DTO et)
        {
            return cn.ExcuteNoneQuery("INSERT INTO SACH (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia, SoLuong) VALUES('" + et.MaSach + "','" + et.MaNXB + "',N'" + et.TenSach + "',N'" + et.TacGia + "',N'" + et.TheLoai + "','" + et.DonGia + "','" + et.SoLuong + "')");
        }
        //Xoa sach
        public bool Xoasach(Sach_DTO et)
        {
            return cn.ExcuteNoneQuery("DELETE FROM SACH WHERE MaSach ='" + et.MaSach + "'");
        }
        public string LayMaMax()
        {
            string sql = @"SELECT MAX(MaSach) FROM SACH";
            return cn.GetValue(sql);
        }
        public string KiemTraMaNXB(int MaNXB)
        {
            string sql = @"SELECT MaNXB FROM NXB WHERE MaNXB = '" + MaNXB +"'";
            return cn.GetValue(sql);
        }
        public DataSet Goiytimkiem()
        {
            string sql = @"SELECT TenSach FROM SACH";
            return cn.EXreader(sql);
        }
    }
}