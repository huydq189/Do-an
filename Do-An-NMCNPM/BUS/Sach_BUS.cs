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
        public static void ThemSach(Sach_DTO sach)
        {
           // Sach_DAL.ThemSach(sach);
        }
        //Xoa sach
        public static void XoaSach(int MaSach)
        {
            //Sach_DAL.XoaSach(MaSach);
        }
        //Timtheotheloai
        public static void Timtheloai(string TheLoai)
        {
            //Sach_DAL.Timtheotheloai(TheLoai);
        }
        //Tim theo tac gia
        public static void Timtacgia(string TacGia)
        {
            //Sach_DAL.Timtheotacgia(TacGia); 
        }
        //Timtheomasach
        public static void Timmasach(int MaSach)
        {
           // Sach_DAL.Timtheomasach(MaSach);
        }
        //TimtheoTensach
        public static void Timtheotensach(string TenSach)
        {
          //Sach_DAL.//TimTheotensach(TenSach);
        }
    }
}
