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
            string sql = "select TonToiThieuTruocNhap, SoLuongNhapItNhat, NoToiDa, TonToiThieuSauBan from QUYDINH";
            return da.GetTable(sql);
        }
        public void thaydoi(QuyDinh_DTO quydinh)
        {
            string sql = "update QUYDINH set TonToiThieuTruocNhap='" + quydinh.TonToiThieu + "',SoLuongNhapItNhat='" + quydinh.SoLuongItNhat + "',NoToiDa='" + quydinh.NoToiDa + "',TonToiThieuSauBan='" + quydinh.Ttts + "' where ID='" + quydinh.ID + "'";
            da.ExcuteNoneQuery(sql);
        }
    }
}
