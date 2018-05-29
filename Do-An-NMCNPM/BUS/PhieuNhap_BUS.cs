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
        public void AddPHIEUNHAP(PhieuNhap_DTO et)
        {
            dal.addPHIEUNHAP(et);
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
        public DataTable SearchPN1()
        {
            return dal.SearchPN1();
        }
    }
}
