using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class HoaDon_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public bool LuuHoaDon(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("INSERT INTO HOADON (MaKH, MaNV, NgHD, TriGia) VALUES('" + hd.MaKH + "','" + hd.MaNV + "','" + hd.NgHD + "','" + hd.TriGia + "')");
        }

        public bool SuaHD(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("UPDATE HOADON SET  MaNV ='" + hd.MaNV + "', MaKH ='" + hd.MaKH + "', NgHD ='" + hd.NgHD + "', TriGia ='" + hd.TriGia + " ' WHERE MaHD='" + hd.MaHD + "'");
        }

        public bool XoaHD(HoaDon_DTO hd)
        {
            return cn.ExcuteNoneQuery("DELETE FROM HOADON WHERE MaHD='" + hd.MaHD + "'");
        }

        public DataTable LayDuLieu(string DK)
        {
            return cn.GetTable("SELECT * FROM HOADON WHERE " + DK);
        }
        public string LayMaHDMax()
        {
            return cn.GetValue("SELECT MAX(MaHD) FROM HOADON");
        }
        public string LaySoLuong()
        {
            return cn.GetValue("SELECT TonToiThieuSauBan FROM QUYDINH");
        }
        public string LayNoToiDa()
        {
            return cn.GetValue("SELECT NoToiDa FROM QUYDINH");
        }
        public string LayTienNoKH(string Makh)
        {
            return cn.GetValue("SELECT SoTienNo FROM KHACHHANG WHERE MaKH= '" + Makh + "'");
        }
    }
}
