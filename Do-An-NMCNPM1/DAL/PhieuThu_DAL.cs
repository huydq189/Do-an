using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class PhieuThu_DAL
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable showPT()
        {
            string sql = "select *from PHIEUTHU";
            return da.GetTable(sql);
        }
        public void insertPT(PhieuThu_DTO phieuthu)
        {
            string sql = "insert into PHIEUTHU values ('" + phieuthu.MaPT + "','" + phieuthu.MaKH + "','" + phieuthu.NgayThu + "','" + phieuthu.MaNV + "','" + phieuthu.SoTienThu + "')";
            da.ExcuteNoneQuery(sql);
        }
    }
}
