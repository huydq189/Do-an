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
    public class HoaDon_BUS
    {
        HoaDon_DAL hd = new HoaDon_DAL();
        public void LuuHoaDon(HoaDon_DTO dt)
        {
            hd.LuuHoaDon(dt);
        }

        public void SuaHD(HoaDon_DTO dt)
        {
            hd.SuaHD(dt);
        }

        public void XoaHD(HoaDon_DTO dt)
        {
            hd.XoaHD(dt);
        }

        public DataTable LayDuLieu(string DK)
        {
            return hd.LayDuLieu(DK);
        }
        public string LayMaHD()
        {
            string a = hd.LayMaHDMax();
            if (a == "")
            {
                return "1";
            }
            else return (int.Parse(a) + 1).ToString();
        }
    }
}
