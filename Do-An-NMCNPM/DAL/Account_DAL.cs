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
        public bool AddAC(Account_DTO a)
        {
            string query = @"INSERT INTO ACCOUNT";
            query += @" (TenTaiKhoan, MatKhau, ChucVu, MaNV)";
            query += @" VALUES        ('" + a.TenTaiKhoan + "','" + a.MatKhau + "','" + a.ChucVu + "','" + a.MaNhanVien + "')";
            return cn.ExcuteNoneQuery(query);
        }
        public bool delAC(Account_DTO a)
        {
            string query = @"DELETE ACCOUNT WHERE MaNV='" + a.MaNhanVien + "'";
            return cn.ExcuteNoneQuery(query);
        }
        public bool Update(Account_DTO a)
        {
            string query = @"UPDATE ACCOUNT ";
            query += @" SET  MatKhau ='" + a.MatKhau + "', ChucVu ='" + a.ChucVu + "'";
            query += @" WHERE MaNV='" + a.MaNhanVien + "'";
            return cn.ExcuteNoneQuery(query);
        }
    }
}
