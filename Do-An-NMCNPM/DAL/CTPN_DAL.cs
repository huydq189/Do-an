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
    public class CTPN_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public bool LuuPN(CTPN_DTO ct)
        {
            return cn.ExcuteNoneQuery("INSERT INTO CTPN (MaPN, MaSach, SoLuongNhap, DonGia) VALUES ('" + ct.MaPN + "','" + ct.MaSach + "','" + ct.SoLuongNhap + "','" + ct.GiaNhap + "')");
        }
        public DataTable LayTT(string dk)
        {
            return cn.GetTable("SELECT MaSach, TenSach, DonGia FROM SACH " + dk);
        }
        public string LaySoLuongSach(string MaSach)
        {
            return cn.GetValue("SELECT SoLuong FROM SACH WHERE MaSach = '" + MaSach + "'");
        }
        public bool UpdateSoLuongSach(string MaSach, string SoLuong)
        {
            return cn.ExcuteNoneQuery("UPDATE SACH SET SoLuong = '" + SoLuong + "' WHERE MaSach = '" + MaSach + "' ");
        }
    }
}
