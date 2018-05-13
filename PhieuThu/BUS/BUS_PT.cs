using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BUS;
using System.Data;

namespace BUS
{
    public class BUS_PT
    {
        DAO_PT da = new DAO_PT();
        //show lên dtgv
        public DataTable showPT()
        {
            string sql = "select MaPT,NgayThu,TienThu from PHIEUTHU";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
      
        public static void Insert(DAO_PT pt)
        {
            try
            {
                MoKetNoi();
                string sql = "insert into PHIEUTHU VALUES ('" + pt.MaPT + "','" + pt.NgayThu + "','"+pt.TienThu+ "')";
                ExcuteNonquery(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
       
    }
    
}
