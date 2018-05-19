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
        public void Suasach(Sach_DTO et)
        {
            cn.ExcuteNoneQuery("UPDATE SACH SET MaSach= '" + et.MaSach + "',MaNXB='" + et.MaNXB + "', TenSach=N'" + et.TenSach + "',TheLoai =N'" + et.TheLoai + "',TacGia=N'" + et.TacGia + "',SoLuong = N'" + et.SoLuong + "' WHERE MaSach ='" + et.MaSach + "'");
        }
        //Xoa sach
        public void Xoasach(Sach_DTO et)
        {
            cn.ExcuteNoneQuery("DELETE FROM SACH WHERE MaSach ='" + et.MaSach + "'");
        }
    }
}