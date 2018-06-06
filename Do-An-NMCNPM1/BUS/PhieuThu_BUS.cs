using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    PhieuThu_DAL pt = new DAL.PhieuThu_DAL();
    class PhieuThu_BUS
    {
        public DataTable showPT()
        {
            return pt.showPT();
        }
        public void insertPT(PhieuThu_DTO et)
        {
            return pt.insertPT(et);
        }
    }
}
