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
    }
}
