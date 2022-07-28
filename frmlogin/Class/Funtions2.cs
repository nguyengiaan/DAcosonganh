using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace frmlogin.Class
{
    public class Funtions2
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");

        public static string Laytennhanvien(string chuoi)
        {
            string a = "";
            SqlDataAdapter sql=new SqlDataAdapter(chuoi,conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            foreach(DataRow dtr in dt.Rows)
            {
                a = dtr["TENNV"].ToString();
            }
            return a;
        }
        public static string Laytenkhachhang(string chuoi)
        {
            string a = "";
            SqlDataAdapter sql = new SqlDataAdapter(chuoi, conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            foreach (DataRow dtr in dt.Rows)
            {
                a = dtr["TENKH"].ToString();
            }
            return a;
        }
        public static int tongtien(string chuoi)
        {
            int b;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            conn.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            sql.CommandText=chuoi;
            var a=sql.ExecuteScalar();
            b = Convert.ToInt32(a);
            return b;
        }
      
    }
}
