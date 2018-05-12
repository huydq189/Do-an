using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoiDB
    {
        public static SqlConnection conn;

        public void MoKetNoi()
        {
            if (KetNoiDB.conn == null)
                KetNoiDB.conn = new SqlConnection(@"Data Source=DESKTOP-OOT7VPD;Initial Catalog=QLNS;Integrated Security=True");
            if (conn.State != ConnectionState.Open)
                KetNoiDB.conn.Open();
        }

        public void DongKetNoi()
        {
            if (KetNoiDB.conn != null)
            {
                if (KetNoiDB.conn.State == ConnectionState.Open)
                    KetNoiDB.conn.Close();
            }
        }

        public bool ExcuteNoneQuery(string StrSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(StrSQL, conn);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {
                DongKetNoi();
                return false;
            }
            return true;
        }

        public DataTable GetTable(string StrSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(StrSQL, conn);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                DongKetNoi();
                return null;

            }
        }

        public string GetValue(string StrSQL)
        {

            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(StrSQL, conn);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }

    }
}
