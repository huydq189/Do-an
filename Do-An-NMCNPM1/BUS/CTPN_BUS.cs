using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class CTPN_BUS
    {
        CTPN_DAL ctpn = new CTPN_DAL();
        public bool LuuCT(CTPN_DTO ct)
        {
            return ctpn.LuuPN(ct);
        }

        public DataTable LayTTHang(string dk)
        {
            return ctpn.LayTT(dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return ctpn.LaySoLuongSach(MaSach);
        }

        public bool UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            return ctpn.UpdateSoLuongSach(MaSach, SoLuong);
        }
    }
}
