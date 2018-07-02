using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class ThongTinNo_BUS
    {
        ThongTinNo_DAL No = new ThongTinNo_DAL();
        public DataTable LayBaoCao(ThongTinNo_DTO a)
        {
            return No.LayBaoCao(a);
        }
        public bool checkTT(string a, string b)
        {
            if (a == "" || b == "")
                return true;
            try
            {
                int.Parse(a);
                int.Parse(b);
            }
            catch
            {
                return true;
            }
            if (int.Parse(a) > 12 || int.Parse(b) < 0)
                return true;
            return false;
        }
    }
}
