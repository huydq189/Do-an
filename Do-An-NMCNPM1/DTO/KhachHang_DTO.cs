using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string _MaKH;
        private string _HoTen;
        private string _SDT;
        private string _SoTienNo;
        private string _Email;
        private string _NgaySinh;
        private string _CMND;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string SoTienNo { get => _SoTienNo; set => _SoTienNo = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
    }
}
