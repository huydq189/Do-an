using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAL NV = new NhanVien_DAL();
        public DataTable LayNhanVien()
        {
            return NV.LayNhanVien();
        }
        public bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NV.ThemNhanVien(nv);
        }
        public bool Xoa(NhanVien_DTO nv)
        {
            return NV.Xoa(nv);
        }
        public bool UpdateNV(NhanVien_DTO nv)
        {
            return NV.UpdateNV(nv);
        }
        public string LayMaNV()
        {
            return (int.Parse(NV.LayMaNVMax()) + 1).ToString();
        }
        public DataTable Search(string a)
        {
            return NV.Search(a);
        }
        public bool CheckNV(NhanVien_DTO nv)
        {
            if (nv.HoTen == "" || nv.MaNV == "" || nv.DiaChi == "" || nv.SDT == "" || nv.NgaySinh == "" || nv.CMND == "")
                return false;
            try { Int64.Parse(nv.SDT); } catch { return false; }
            if (nv.SDT.Length > 12 && nv.SDT.Length < 8)
            {
                return false;
            }
            try { Int64.Parse(nv.CMND); }
            catch { return false; }
            if (nv.CMND.Length == 9 || nv.CMND.Length == 12)
                return true;
            else return false;
        }
    }
}
