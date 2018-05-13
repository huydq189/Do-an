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
    }
}
