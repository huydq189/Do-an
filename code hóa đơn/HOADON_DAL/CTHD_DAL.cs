using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HOADON_DTO;

namespace HOADON_DAL
{
    public class CTHD_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public void LuuHoaDon( CTHD_DTO ct)
        {
            cn.ExcuteNoneQuery("INSERT INTO CTHD (MaHD, MaSach, SoLuong) VALUES ('"+ct.MaHD+"','"+ct.MaSach+"','"+ct.SoLuong+"')");
        }
        public DataTable LayTT(string dk)
        {
            return cn.GetTable("SELECT MaSach, TenSach, DonGia FROM SACH "+dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return cn.GetValue("SELECT SoLuong FROM SACH WHERE MaSach = '" + MaSach + "'");
        }
        public void UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            cn.ExcuteNoneQuery("UPDATE SACH SET SoLuong = '"+SoLuong+"' WHERE MaSach = '" + MaSach + "' ");
        }
    }
}
