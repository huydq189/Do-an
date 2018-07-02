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
    public class Thongtinton_BUS
    {
        Thongtinton_DAL Ton = new Thongtinton_DAL ();
        public DataTable LayBaoCao (Thongtinton_DTO a)
        {
            return Ton.LayBaoCao(a);
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
