using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HOADON_DAL;
using HOADON_DTO;

namespace HOADON_BUS
{
    public class CTHD_BUS
    {
        CTHD_DAL cthd = new CTHD_DAL();
        public void LuuCT(CTHD_DTO ct)
        {
            cthd.LuuHoaDon(ct);
        }

        public DataTable LayTTHang(string dk)
        {
            return cthd.LayTT(dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return cthd.LaySoLuongSach(MaSach);
        }

        public void UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            cthd.UpdateSoLuongSach(MaSach, SoLuong);
        }
    }
}
