using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string _MaNV;
        private string _HoTen;
        private string _SDT;
        private string _CMND;
        private string _NgaySinh;
        private string _DiaChi;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }
}
