using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class Account_BUS
    {
        Account_DAL Account = new Account_DAL();
        public string Login(Account_DTO a)
        {

            return Account.Login(a);
        }
        public string LayChucVu(Account_DTO a)
        {
            return Account.LayChucVu(a);
        }
        public bool AddAC(Account_DTO a)
        {
            return Account.AddAC(a);
        }
        public bool delAC(Account_DTO a)
        {
            return Account.delAC(a);
        }
        public bool Update(Account_DTO a)
        {
            return Account.Update(a);
        }
        public bool Check(Account_DTO a)
        {
            if (a.MaNhanVien == "" || a.MatKhau == "" || a.TenTaiKhoan == "" || a.ChucVu == "")
                return false;
            if (a.ChucVu == "admin" || a.ChucVu == "user")
                return true;
            else return false;
        }
    }
}
