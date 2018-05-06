using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOADON_DTO
{
    public class Sach_DTO
    {
        private string _MaSach;
        private string _MaNXB;
        private string _TenSach;
        private string _TacGia;
        private string _TheLoai;
        private float _DonGia;
        private string _SoLuong;

        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string MaNXB { get => _MaNXB; set => _MaNXB = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public string TacGia { get => _TacGia; set => _TacGia = value; }
        public string TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public float DonGia { get => _DonGia; set => _DonGia = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
