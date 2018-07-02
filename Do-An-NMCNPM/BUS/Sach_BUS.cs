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
        //Xoa sach
        public bool XoaSach(Sach_DTO et)
        {
            return dal.Xoasach(et);
        }
        //Themsach
        public bool ThemSach(Sach_DTO et)
        {
            return dal.Themsach(et);
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
        public bool SuaSach(Sach_DTO et)
        {
            return dal.Suasach(et);
        }
        public string LayMaSach()
        {
            return (int.Parse(dal.LayMaMax()) + 1).ToString();
        }
        public string KTMaNXB(int MaNXB)
        {
            return dal.KiemTraMaNXB(MaNXB);
        }
        public DataSet GoiYTimKiem()
        {
            return dal.Goiytimkiem();
        }
    }
}
