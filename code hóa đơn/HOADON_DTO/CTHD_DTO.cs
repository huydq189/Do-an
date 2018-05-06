using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOADON_DTO
{
    public class CTHD_DTO
    {
        private string _MaHD;
        private string _MaSach;
        private string _SoLuong;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
