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
    public class Sach_BUS
    {
        //LoadDSSach
        Sach_DAL dal = new Sach_DAL();
        public DataTable LoadDSSach()
        {
            return dal.LoadDSTatCaSach();
        }
        //Themsach
        public void ThemSach(Sach_DTO sach)
        {
           // Sach_DAL.ThemSach(sach);
        }
        //Xoa sach
        public static void XoaSach(int MaSach)
        {
            //Sach_DAL.XoaSach(MaSach);
        }
        //Timtheotheloai
        public DataTable Timtheloai(string TheLoai)
        {
            return dal.Timtheotheloai(TheLoai);
        }
        //Tim theo tac gia
        public DataTable Timtacgia(string TacGia)
        {
            return dal.Timtheotacgia(TacGia);
        }
        //Timtheomasach
        public DataTable Timmasach(int MaSach)
        {
            return dal.Timtheomasach(MaSach);
        }
        //TimtheoTensach
        public DataTable Timtheotensach(string TenSach)
        {
            return dal.TimTheotensach(TenSach);
        }
        public void SuaSach(Sach_DTO et)
        {
            dal.Suasach(et);
        }
    }
}
