using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Thongtinton_DTO
    {
        private int _Id;
        private int _Thang;
        private int _Nam;
        private double _TonDau;
        private double _TonPhatSinh;
        private double _TonCuoi;
        private int _MaSach;

        public int Id { get => _Id; set => _Id = value; }
        public int Thang { get => _Thang; set => _Thang = value; }
        public int Nam { get => _Nam; set => _Nam = value; }
        public double TonDau { get => _TonDau; set => _TonDau = value; }
        public double TonPhatSinh { get => _TonPhatSinh; set => _TonPhatSinh = value; }
        public double TonCuoi { get => _TonCuoi; set => _TonCuoi = value; }
        public int MaSach { get => _MaSach; set => _MaSach = value; }
    }
}
