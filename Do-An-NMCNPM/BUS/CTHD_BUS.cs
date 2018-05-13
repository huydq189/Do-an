using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class CTHD_BUS
    {
        CTHD_DAL cthd = new CTHD_DAL();
        public bool LuuCT(CTHD_DTO ct)
        {
            return cthd.LuuHoaDon(ct);
        }

        public DataTable LayTTHang(string dk)
        {
            return cthd.LayTT(dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return cthd.LaySoLuongSach(MaSach);
        }

        public bool UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            return cthd.UpdateSoLuongSach(MaSach, SoLuong);
        }
    }
}
