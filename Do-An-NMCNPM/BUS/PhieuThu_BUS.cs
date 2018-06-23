using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class PhieuThu_BUS
    {
        PhieuThu_DAL pt = new DAL.PhieuThu_DAL();
        public DataTable showPT()
        {
            return pt.showPT();
        }
        public void insertPT(PhieuThu_DTO et)
        {
            pt.InsertPT(et);
        }
    }
}
