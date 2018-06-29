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
    public class PhieuNhap_BUS
    {
        PhieuNhap_DAL dal = new PhieuNhap_DAL();
        public DataTable Hienthiphieunhap()
        {
            return dal.SelectPhieuNhapAll();
        }
        public DataTable Hienthictphieunhap()
        {
            return dal.SelectPhieuNhapChiTietAll();
        }
        public bool themphieunhap(PhieuNhap_DTO et)
        {
            dal.Insertphieunhap(et);
            return true;
        }
        public bool themchitietphieunhap(PhieuNhap_DTO p)
        {
            if (dal.GetPhieuNhapByName(p.MaPN, p.MaSach) == null)
            {
                dal.Insert(p);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Combosach()
        {
            return dal.LayDuLieu();
        }
        public int getMaSach(string a)
        {
            return dal.getMaSach(a);
        }
        public int getSoLuong(Sach_DTO et)
        {
            return dal.getSOLUONG(et);
        }
        public void updatesoluong(Sach_DTO sach)
        {
            dal.updateSOLUONGSACH(sach);
        }
        public DataTable GetThamSoAll()
        {
            return dal.GetThamSoAll();
        }
        public DataTable SlectSoLuongTon(int masach)
        {
            return dal.SlectSoLuongTon(masach);
        }
        public string LayMaPN()
        {
            string a = dal.LayMaPNMax();
            if (a == "")
            {
                return "1";
            }
            else return (int.Parse(a) + 1).ToString();
        }
        public double LayTongTien(int MaPN)
        {
            return dal.Laytongtien(MaPN);
        }
        public bool LuuPN(PhieuNhap_DTO p)
        {
            dal.LuuPN(p);
            return true;
        }
    }
}
