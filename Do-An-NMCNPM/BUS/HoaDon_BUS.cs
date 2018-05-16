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
        public bool LuuHoaDon(HoaDon_DTO dt)
        {
            return hd.LuuHoaDon(dt);
        }

        public bool SuaHD(HoaDon_DTO dt)
        {
            return hd.SuaHD(dt);
        }

        public bool XoaHD(HoaDon_DTO dt)
        {
            return hd.XoaHD(dt);
        }

        public DataTable LayDuLieu()
        {
            return hd.LayDuLieu();
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
        public string LaySoLuong()
        {
            return hd.LaySoLuong();
        }
        public string LayNoToiDa()
        {
            return hd.LayNoToiDa();
        }
        public string LayTienNoKH(string Makh)
        {
            return hd.LayTienNoKH(Makh);
        }
        public DataTable LayMaKH()
        {
            return hd.LayMaKH();
        }
        public bool UpdateTienNo(string MaKH, double TienNo)
        {
            return hd.UpdateTienNo(MaKH,TienNo);
        }
        public bool UpdateHoaDonLoi(string MaHD)
        {
            return hd.UpdateHoaDonLoi(MaHD);
        }
        public DataTable SearchMaKH(String MaKH)
        {
            return hd.SearchMaKH(MaKH);
        }

        public DataTable SearchDate(string a, string b)
        {
            return hd.SearchDate(a, b);
        }
    }
}
