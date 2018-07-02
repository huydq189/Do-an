using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Thongtinton_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayBaoCao(Thongtinton_DTO a)
        {
            String sql = @"SELECT MaSach,TonDau,TonPhatSinh,TonCuoi FROM THONGTINTONKHO WHERE Thang = '" + a.Thang+"' AND Nam = '"+ a.Nam+ "'";
            return cn.GetTable(sql);

        }
    }
}
