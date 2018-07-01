using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class CTHD_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public bool LuuHoaDon(CTHD_DTO ct)
        {
            return cn.ExcuteNoneQuery("INSERT INTO CTHD (MaHD, MaSach, SoLuong) VALUES ('" + ct.MaHD + "','" + ct.MaSach + "','" + ct.SoLuong + "')");
        }
        public DataTable LayTT(string dk)
        {
            return cn.GetTable("SELECT MaSach, TenSach, DonGia*1.05 AS DonGia FROM SACH " + dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return cn.GetValue("SELECT SoLuong FROM SACH WHERE MaSach = '" + MaSach + "'");
        }
        public bool UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            return cn.ExcuteNoneQuery("UPDATE SACH SET SoLuong = '" + SoLuong + "' WHERE MaSach = '" + MaSach + "' ");
        }
    }
}
