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
        public DataTable SelectPhieuNhapAll()
        {
            return cn.GetTable("select *from PHIEUNHAP");
        }
        public DataTable SelectPhieuNhapChiTietAll()
        {
            return cn.GetTable("select *from CTPHIEUNHAP");
        }
        public void Insert(PhieuNhap_DTO p)
        {
            cn.ExcuteNoneQuery("insert into CTPHIEUNHAP(MaPN,MaSach,SoLuongNhap) values(" + p.MaPN + "," + p.MaSach + "," + p.SoLuong + ")");
        }
        public void Insertphieunhap(PhieuNhap_DTO p)
        {
            cn.ExcuteNoneQuery("INSERT INTO PHIEUNHAP (MaPN,MaNV,NgayNhap,TongChi) VALUES('" + p.MaPN + "','" + p.MaNV + "','" + p.NgayNhap + "','" + p.TongTien + "')");
        }
        public  PhieuNhap_DTO GetPhieuNhapByName(int maphieunhap, int masach)
        {
            string sql = "select * from CTPHIEUNHAP where ((MaPN=" + maphieunhap + ")AND(MaSach = " + masach + "))";
            DataTable dt = cn.GetTable(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.MaPN = (int)dt.Rows[0].ItemArray[0];
                return pn;
            }
        }
        public DataTable LayDuLieu()
        {
            return cn.GetTable("SELECT * FROM SACH");
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
        public DataTable GetThamSoAll()
        {
            return cn.GetTable ("select * from QUYDINH");
        }
        public DataTable SlectSoLuongTon(int masach)
        {
              return cn.GetTable("select * from SACH where MaSach=" + masach + "");
            
        }
        public string LayMaPNMax()
        {
            return cn.GetValue("SELECT MAX(MaPN) FROM PHIEUNHAP");
        }
        public double Laytongtien(int MaPN)
        {
            return double.Parse(cn.GetValue("Select SUM(CTPHIEUNHAP.SoLuongNhap*SACH.DonGia) from CTPHIEUNHAP join SACH on CTPHIEUNHAP.MaSach = SACH.MaSach join PHIEUNHAP on PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN where PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN and CTPHIEUNHAP.MaPN =" + MaPN + ""));
        }
        public void LuuPN(PhieuNhap_DTO p)
        {
            cn.ExcuteNoneQuery("UPDATE PHIEUNHAP set  MaPN = '" + p.MaPN + "', MaNV = '" + p.MaNV + "', NgayNhap = '" + p.NgayNhap + "', TongChi = '" + p.TongTien + "' where MaPN = '" + p.MaPN + "'");
        }
    }
    
}
