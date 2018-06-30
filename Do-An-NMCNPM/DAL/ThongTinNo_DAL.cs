using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class ThongTinNo_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayBaoCao(ThongTinNo_DTO a)
        {
            string sql = @"SELECT MaKH, NoDau,PhatSinh,NoCuoi FROM THONGTINNO WHERE Thang ='" + a.Thang + "' AND Nam = '" + a.Nam + "'";
            return cn.GetTable(sql);
        }
    }
}
