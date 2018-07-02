using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class QuyDinh_BUS
    {
        QuyDinh_DAL qd = new QuyDinh_DAL();
        public DataTable showQD()
        {
            return qd.showQD();
        }
        public void ThayDoi(int B, int C, double D, int E, string F)
        {
            qd.thaydoi(B, C, D, E, F);
        }
    }
}
