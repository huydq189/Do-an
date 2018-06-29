using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class NhanVien_DAL
    {
        KetNoiDB cn = new KetNoiDB();
        public DataTable LayNhanVien()
        {
            string query= @"SELECT NHANVIEN.MaNV,HoTen,DiaChi,SDT,CMND,NgaySinh,TenTaiKhoan,MatKhau,ChucVu";
            query += @" FROM NHANVIEN, ACCOUNT";
            query += @" WHERE NHANVIEN.MaNV=ACCOUNT.MaNV";
            return cn.GetTable(query);
        }

        public bool ThemNhanVien(NhanVien_DTO nv)
        {
            string query = @"INSERT INTO NHANVIEN ";
            query += @" (MaNV, HoTen, SDT, CMND, NgaySinh, DiaChi)";
            query += @" VALUES  ('" + nv.MaNV + "',N'" + nv.HoTen + "','" + nv.SDT + "','" + nv.CMND + "','" + nv.NgaySinh + "',N'" + nv.DiaChi + "')";
            return cn.ExcuteNoneQuery(query);
        }
        public bool Xoa(NhanVien_DTO nv)
        {
            string query = @"DELETE NHANVIEN,ACC WHERE MaNV='" + nv.MaNV + "'";
            return cn.ExcuteNoneQuery(query);
        }
        public bool UpdateNV(NhanVien_DTO nv)
        {
            //string query = @"SET DATEFORMAT DMY ";
            string query = @" UPDATE       NHANVIEN ";
            query += @" SET   HoTen =N'"+nv.HoTen+"', SDT ='"+nv.SDT+"', CMND ='"+nv.CMND+"', DiaChi =N'"+nv.DiaChi+"', NgaySinh ='"+nv.NgaySinh+"'";
            query += @" WHERE MaNV='" + nv.MaNV + "'";
            return cn.ExcuteNoneQuery(query);
        }
        public string LayMaNVMax()
        {
            string sql = @" SELECT MAX(MaNV) FROM NHANVIEN";
            return cn.GetValue(sql);
        }

        public DataTable Search(string a)
        {
            string sql = @"SELECT NHANVIEN.MaNV,HoTen,DiaChi,SDT,CMND,NgaySinh,TenTaiKhoan,MatKhau,ChucVu";
            sql += @"  FROM NHANVIEN, ACCOUNT WHERE NHANVIEN.MaNV=ACCOUNT.MaNV AND HoTen LIKE N'%" + a + "%'";
            return cn.GetTable(sql);
        }

    }
}
