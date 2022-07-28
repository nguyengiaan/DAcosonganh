using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace frmlogin.Class
{
    class Funtions
    {
        string s = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
         public static SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
      
        public static void Connect()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Kết nối thành công");
            }
        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static DataTable GetDataTable(string s)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(s,con);
            adapter.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            try
            {

                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0)
                    return true;
                return false;
            }
            catch { MessageBox.Show("Lỗi Truy vấn", "Thông báo"); }
            return false;
        }
        public static void RunSQL(string sql)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            con.Open();
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public static string GetFieldValues(string sql)
        {
           SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGHJH2J\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            con.Open();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static int CreateKey()
        {
            int ma = 0;
         
            SqlDataAdapter dt = new SqlDataAdapter("SELECT * FROM HOADON",con);
            DataTable dta = new DataTable();
            dt.Fill(dta);
            ma = Convert.ToInt32(dta.Rows[dta.Rows.Count-1][0].ToString());
            ma = ma + 1;
            return ma;
        }
        public static int CreateKey1(string str)
        {
            int ma = 0;

            SqlDataAdapter dt = new SqlDataAdapter(str, con);
            DataTable dta = new DataTable();
            dt.Fill(dta);
            ma = Convert.ToInt32(dta.Rows[dta.Rows.Count - 1][0].ToString());
            ma = ma + 1;
            return ma;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        //internal static object CreateKey()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
