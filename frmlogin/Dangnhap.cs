using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace frmlogin
{
    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        string s = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
        public static string permission = "";
        public static string ID = "";
        SqlConnection conn;
        private string getham()
        {
            string id = "";
            conn = new SqlConnection(s);
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM DANGNHAP WHERE TENTK ='" + txt_ten.Text + "' and MATKHAU='" + hashpass(txt_password.Text) + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["QUYEN"].ToString();
                        ID = dr["ID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
        private string hashpass(string pass)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pass));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return pass.ToString();
            }
        }

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            permission = getham();
            if (permission != "")
            {
                GiaoDienChinh gd = new GiaoDienChinh();
                gd.username = permission;
                gd.Show();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu", "thông báo");
            }
        }
    }
}
