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

            string query = "select MaNV from Account where TenTaiKhoan = '" + a.TenTaiKhoan + "'" ;
            query += " COLLATE SQL_Latin1_General_CP1_CS_AS and MatKhau = '" + a.MatKhau + "'";
            query += " COLLATE SQL_Latin1_General_CP1_CS_AS";
            return cn.GetValue(query);
        }
        public string LayChucVu(Account_DTO a)
        {
            return  cn.GetValue("SELECT ChucVu FROM Account WHERE MaNV='" + a.MaNhanVien + "'");
        }

    }
}
