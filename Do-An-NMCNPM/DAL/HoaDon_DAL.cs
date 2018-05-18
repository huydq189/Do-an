using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class HoaDon_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public bool LuuHoaDon(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("SET DATEFORMAT DMY INSERT INTO HOADON (MaHD,MaKH, MaNV, NgHD, TriGia,SoTienThu,SoTienNo) VALUES('"+hd.MaHD+"','" + hd.MaKH + "','" + hd.MaNV + "','" + hd.NgHD + "','" + hd.TriGia + "','"+hd.SoTienThu+"','"+hd.SoTienNo+"')");
        }

        public bool SuaHD(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("UPDATE HOADON SET  MaNV ='" + hd.MaNV + "', MaKH ='" + hd.MaKH + "', NgHD ='" + hd.NgHD + "', TriGia ='" + hd.TriGia + " ', SoTienThu='"+hd.SoTienThu+"', SoTienNo='"+hd.SoTienNo+"' WHERE MaHD='" + hd.MaHD + "'");
        }

        public bool XoaHD(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("DELETE FROM HOADON WHERE MaHD='" + hd.MaHD + "'");
        }

        public DataTable LayDuLieu()
        {
            return cn.GetTable("SELECT * FROM HOADON");
        }
        public string LayMaHDMax()
        {
            return cn.GetValue("SELECT MAX(MaHD) FROM HOADON");
        }
        public string LaySoLuong()
        {
            return cn.GetValue("SELECT TonToiThieuSauBan FROM QUYDINH");
        }
        public string LayNoToiDa()
        {
            return cn.GetValue("SELECT NoToiDa FROM QUYDINH");
        }
        public string LayTienNoKH(string Makh)
        {
            return cn.GetValue("SELECT SoTienNo FROM KHACHHANG WHERE MaKH= '" + Makh + "'");
        }
        public DataTable LayMaKH()
        {
            return cn.GetTable("SELECT MaKH FROM KHACHHANG WHERE MaKH > 1");
        }

        public bool UpdateTienNo(string MaKH, double TienNo)
        {
            return cn.ExcuteNoneQuery("UPDATE KHACHHANG SET SoTienNo= '" + TienNo + "' WHERE MaKH='" + MaKH + "'");
        }
        public bool UpdateHoaDonLoi(string MaHD)
        {
            return cn.ExcuteNoneQuery("UPDATE HOADON SET TriGia= '0' WHERE MAHD='" + MaHD + "' ");
        }
        public DataTable SearchMaKH(String MaKH)
        {
            return cn.GetTable("SELECT * FROM HOADON WHERE MaKH='" + MaKH + "'");
        }
        public DataTable SearchDate(string a, string b)
        {
            //string  sql = @"set dateformat dmy";
                    string sql=      @" SELECT* FROM HOADON";
                    sql += @" WHERE NgHD BETWEEN '" + a + "' AND '" + b + "'";
            return cn.GetTable(sql);
        }
        /*public bool TaoPhieuThu(HoaDon_DTO hd, string a)
        {
            string query = @"SET DATEFORMAT DMY";
            query += @" INSERT INTO PHIEUTHU";
            query += @"(MaKH, NgayThu, MaNV,SoTienThu)";
            query += @"VALUES        ('" + hd.MaKH + "','" + hd.NgHD + "','" + hd.MaNV + "','" + a + "')";
            return cn.ExcuteNoneQuery(query);
        }*/
        public DataTable getCTHD(string MaHD)
        {
            string query = @"SELECT SACH.MaNXB, SACH.TenSach,SACH.TacGia,SACH.TheLoai,CTHD.SoLuong ";
            query += @" FROM CTHD JOIN SACH ON CTHD.MaSach=SACH.MaSach ";
            query += @" WHERE MaHD= '" + MaHD + "'";
            return cn.GetTable(query);
        }
    }
}
