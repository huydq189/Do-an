using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public double DonGia { get; set; }
        public int MaNXB { get; set; }
        public int SoLuong = 0;
    }
}
