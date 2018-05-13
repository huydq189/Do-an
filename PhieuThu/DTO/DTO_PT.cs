using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PT
    {
        private string mapt;
        private string makh;
        private string ngaythu;
        private string manv;
        private string tienthu;
        public string MaPT
        {
            get { return mapt; }
            set { mapt = value; }
        }
        public string MaKH { get ; set ; }
        public string NgayThu{ get ; set ; }
        public string MaNV { get ; set  ; }
        public string TienThu { get ; set ; }
    }
}
