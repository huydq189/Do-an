using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhachHang_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayBangKH()
        {
            return cn.GetTable("SELECT * FROM KHACHHANG WHERE MaKH != 1");
        }
        public bool ThemKhachHang(KhachHang_DTO kh)
        {
            string query = @"SET DATEFORMAT DMY";
            query += @" INSERT INTO KHACHHANG";
            query += @" (MaKH, HoTen, SDT, SoTienNo, CMND, Email, NgaySinh)";
            query+= @" VALUES  ('"+kh.MaKH+"',N'"+kh.HoTen+"','"+kh.SDT+"','"+kh.SoTienNo+"','"+kh.CMND+"',N'"+kh.Email+"','"+kh.NgaySinh+"')";
            return cn.ExcuteNoneQuery(query);
        }
        public bool UpdateKH(KhachHang_DTO kh)
        {
            string query = @"SET DATEFORMAT DMY ";
            query += @" UPDATE       KHACHHANG ";
            query += @" SET HoTen =N'" + kh.HoTen + "', SDT ='" + kh.SDT + "', SoTienNo ='" + kh.SoTienNo + "', Email =N'" + kh.Email + "', CMND ='" + kh.CMND + "', NgaySinh ='" + kh.NgaySinh + "'";
            query+=@" WHERE MaKH='"+kh.MaKH+"'";
            return cn.ExcuteNoneQuery(query);
        }
        public bool XoaKH(KhachHang_DTO kh)
        {
            string query = @"DELETE KHACHHANG WHERE MaKH='"+kh.MaKH+"'";
            return cn.ExcuteNoneQuery(query);
        }
    }
}
