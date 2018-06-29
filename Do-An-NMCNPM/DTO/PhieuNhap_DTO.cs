using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap_DTO
    {
        public int MaPN { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaSach { get; set; }
        public double TongTien { get; set; }
        public int SoLuong { get; set; }
    }
}
