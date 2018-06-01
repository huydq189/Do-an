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
    public class PhieuNhap_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayDuLieu()
        {
            return cn.GetTable("SELECT * FROM SACH");
        }
        public void addPHIEUNHAP(PhieuNhap_DTO phieunhap)
        {
            string sql = "INSERT INTO PHIEUNHAP (MaPN,MaNV,NgayNhap,TongChi) VALUES('" + phieunhap.MaPN + "','" + phieunhap.MaNV + "','" + phieunhap.NGAYNHAP + "','" + phieunhap.TongTien + "')";
            cn.ExcuteNoneQuery(sql);
        }
        public int getMaSach(string a)
        {
            string sql = " select MaSach from SACH where TenSach = '" + a + "' ";
            return cn.ExScalar(sql);
        }
        public int getSOLUONG(Sach_DTO sach)
        {
            string sql = "select SoLuong from SACH where MaSach ='" + sach.MaSach + "'";
            return cn.ExScalar(sql);

        }
        public void updateSOLUONGSACH(Sach_DTO book)
        {
            string sql = " update SACH set SoLuong ='" + book.SoLuong + "' where MaSach='" + book.MaSach + "'";
            cn.ExcuteNoneQuery(sql);
        }
        public DataTable SearchPN1()

        {
            string sql = "select * from CTPHIEUNHAP";
            return cn.GetTable(sql);
        }
    }
    
}
