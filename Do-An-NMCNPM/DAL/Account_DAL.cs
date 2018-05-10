using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class Account_DAL
    {
        KetNoiDB cn = new KetNoiDB(); 
        public string Login(Account_DTO a)
        {

            return cn.GetValue("select MaNV from Account where TenTaiKhoan= '" +a.TenTaiKhoan  + "'  and MatKhau='" + a.MatKhau + "'");
        }
        public string LayChucVu(Account_DTO a)
        {
            return  cn.GetValue("SELECT ChucVu FROM Account WHERE MaNV='" + a.MaNhanVien + "'");
        }

    }
}
