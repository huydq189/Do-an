using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NXB_DTO
    {
        private int _maNXB;

        public int MaNXB { get => _maNXB; set => _maNXB = value; }
        public string TenNXB { get => _tenNXB; set => _tenNXB = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }

        private string _tenNXB;
        private string _diachi;
        private string _sdt;
        public NXB_DTO(string tenNXB, string diachi, string sdt)
        {
            TenNXB = tenNXB;
            Diachi = diachi;
            Sdt = sdt;
        }
    }
}
