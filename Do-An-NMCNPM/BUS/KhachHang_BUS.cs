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
    public class KhachHang_BUS
    {
        KhachHang_DAL khDal = new KhachHang_DAL();
        public DataTable LayBangKH()
        {
            return khDal.LayBangKH();
        }
        public bool ThemKhachHang(KhachHang_DTO kh)
        {
            return khDal.ThemKhachHang(kh);
        }
        public bool UpdateKH(KhachHang_DTO kh)
        {
            return khDal.UpdateKH(kh);
            
        }
        public bool XoaKH(KhachHang_DTO kh)
        {
            return khDal.XoaKH(kh);
        }
        public string LayMaKH()
        {
            return (int.Parse(khDal.LayMaKHMax()) + 1).ToString();
        }
        public DataTable searchKH(string a)
        {
            return khDal.searchKH(a);
        }
        public bool CheckKH(KhachHang_DTO KH)
        {
            if (KH.HoTen == "" || KH.MaKH == "" || KH.NgaySinh == "" || KH.SDT == "" || KH.CMND == "" || KH.Email == ""||KH.SoTienNo=="")
                return false;
            try { Int64.Parse(KH.SDT); } catch { return false; }
            if (KH.SDT.Length > 12 && KH.SDT.Length < 8)
            {
                return false;
            }
            try { Int64.Parse(KH.CMND); }
            catch { return false; }
            try { Int64.Parse(KH.SoTienNo); } catch { return false; }
            if (KH.CMND.Length == 9 || KH.CMND.Length == 12)
                return true;
            else return false;
        }
    }
}
