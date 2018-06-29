using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinNo_DTO
    {
        private int _Id;
        private int _Thang;
        private int _Nam;
        private double _NoDau;
        private double _NoCuoi;
        private double _PhatSinh;
        private int _MaKH;

        public int Id { get => _Id; set => _Id = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public double NoDau { get => _NoDau; set => _NoDau = value; }
        public double NoCuoi { get => _NoCuoi; set => _NoCuoi = value; }
        public double PhatSinh { get => _PhatSinh; set => _PhatSinh = value; }
        public int MaKH { get => _MaKH; set => _MaKH = value; }
    }
}
