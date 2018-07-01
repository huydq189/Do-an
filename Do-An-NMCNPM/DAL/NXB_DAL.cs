using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class NXB_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        //Load danh sach tat ca NXB

        public DataTable LoadDSNXB()
        {
            return cn.GetTable("SELECT * FROM NXB");
        }
        //Sua NXB
        public bool SuaNXB(NXB_DTO nxb)
        {
            return cn.ExcuteNoneQuery("UPDATE NXB set  TenNXB = N'" + nxb.TenNXB + "', DiaChi = N'" + nxb.Diachi + "', SDT = '" + nxb.Sdt + "' where MaNXB = '" + nxb.MaNXB + "'");
        }
        //Them NXB
        public bool ThemNXB(NXB_DTO nxb)
        {
            return cn.ExcuteNoneQuery("INSERT INTO NXB (MaNXB,TenNXB,DiaChi,SDT) VALUES('" + nxb.MaNXB + "',N'" + nxb.TenNXB + "',N'" + nxb.Diachi + "','" + nxb.Sdt + "')");
        }
        //Xoa NXB
        public bool XoaNXB(NXB_DTO nxb)
        { 
            return cn.ExcuteNoneQuery("DELETE FROM NXB WHERE MaNXB ='" + nxb.MaNXB + "'");
        }
        public DataTable TimtheomaNXB(int MaNXB)
        {
            return cn.GetTable("SELECT * FROM NXB WHERE MaSach = '" + MaNXB + "'");
        }
        public string LayMaMax()
        {
            string sql = @"SELECT MAX(MaNXB) FROM NXB";
            return cn.GetValue(sql);
        }
    }
}
