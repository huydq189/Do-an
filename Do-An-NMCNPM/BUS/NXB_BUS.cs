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
    public class NXB_BUS
    {
        NXB_DAL dal = new NXB_DAL();
        public DataTable HTNXB()
        {
            return dal.LoadDSNXB();
        }
        public bool ThemNXB(NXB_DTO n)
        {
            return dal.ThemNXB(n);
        }
        public bool SuaNXB(NXB_DTO n)
        {
            return dal.SuaNXB(n);
        }
        public bool XoaNXB(NXB_DTO n)
        {
            return dal.XoaNXB(n);
        }
        public DataTable TimNXB(int manxb)
        {
            return dal.TimtheomaNXB(manxb);
        }
        public string LayMaNXB()
        {
            return (int.Parse(dal.LayMaMax()) + 1).ToString();
        }
    }
}
