using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string _MaNV;
        private string _MaKH;
        private string _MaHD;
        private string _NgHD;
        private string _TriGia;


        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string NgHD { get => _NgHD; set => _NgHD = value; }
        public string TriGia { get => _TriGia; set => _TriGia = value; }
    }
}
