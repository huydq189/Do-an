using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class QuyDinh_DAL
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable showQD()
        {
            string sql = "select * from QUYDINH";
            return da.GetTable(sql);
        }
        public void thaydoi(int b, int c, double d, int e, string f)
        {
            string sql = "UPDATE QUYDINH SET TonToiThieuTruocNhap='" + b + "',SoLuongNhapItNhat='" + c + "',NoToiDa='" + d + "',TonToiThieuSauBan='" + e + "',QDThuTien='" + f + "'";
            da.ExcuteNoneQuery(sql);
        }
    }
}
