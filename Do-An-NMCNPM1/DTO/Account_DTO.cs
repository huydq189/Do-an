using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string _TenTaiKhoan;
        private string _MatKhau;
        private string _ChucVu;
        private string _MaNhanVien;

        public string TenTaiKhoan { get => _TenTaiKhoan; set => _TenTaiKhoan = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
    }
}
