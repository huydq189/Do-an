using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOADON_DTO;
using System.Data;

namespace HOADON_DAL
{
    public class HoaDon_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public void LuuHoaDon(HoaDon_DTO hd)
        {
            cn.ExcuteNoneQuery("INSERT INTO HOADON (MaKH, MaNV, NgHD, TriGia) VALUES('"+hd.MaKH+"','"+hd.MaNV+"','"+hd.NgHD+"','"+hd.TriGia+"')");
        }

        public void SuaHD(HoaDon_DTO hd)
        {
            cn.ExcuteNoneQuery("UPDATE HOADON SET  MaNV ='"+hd.MaNV+"', MaKH ='"+hd.MaKH+"', NgHD ='"+hd.NgHD+"', TriGia ='"+hd.TriGia+" ' WHERE MaHD='"+hd.MaHD+"'");
        }

        public void XoaHD(HoaDon_DTO hd)
        {
            cn.ExcuteNoneQuery("DELETE FROM HOADON WHERE MaHD='" + hd.MaHD + "'");
        }

        public DataTable LayDuLieu(string DK)
        {
            return cn.GetTable("SELECT * FROM HOADON WHERE " + DK);
        }
        public string LayMaHDMax()
        {
            return cn.GetValue("SELECT MAX(MaHD) FROM HOADON");
        }
    }

}
