using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class PhieuThu_DAL
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable showPT()
        {
            string sql = "select * from PHIEUTHU";
            return da.GetTable(sql);
        }
        public void InsertPT(PhieuThu_DTO phieuthu)
        {
            string sql = "insert into PHIEUTHU values ('" + phieuthu.MaPT + "','" + phieuthu.MaKH + "','" + phieuthu.NgayThu + "','" + phieuthu.MaNV + "','" + phieuthu.SoTienThu + "')";
            da.ExcuteNoneQuery(sql);
        }
        public string LayQuyDinh()
        {
            return da.GetValue("select QDThuTien from QUYDINH ");
        }
        public string LaySoTien(PhieuThu_DTO lt)
        {
            return da.GetValue("select SoTienNo from KHACHHANG where MaKH='" + lt.MaKH + "'");
        }
        public void updateSTN(double stn, int makh)
        {
            string sql = "update KHACHHANG set SoTienNo='" + stn + "' where MaKH='" + makh + "'";
            da.ExcuteNoneQuery(sql);
        }
    }
}
