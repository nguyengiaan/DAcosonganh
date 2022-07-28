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
namespace frmlogin
{
    public partial class TaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        string s = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con;
       // SqlCommand cmd;
       
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void hienthidulieu()
        {
            con = new SqlConnection(s);
            con.Open();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MANV='" + Dangnhap.ID + "'", con);
            DataTable dtb = new DataTable("NhanVien");
            dt.Fill(dtb);
            if (dtb != null)
            {
                foreach (DataRow row in dtb.Rows)
                {
                    txt_manhanvien.Text = row["MANV"].ToString();
                    txt_tennhanvien.Text = row["TENNV"].ToString();
                    txt_diachi.Text = row["DIACHI"].ToString();
                    txt_sodienthoai.Text = row["SDT"].ToString();
                    txt_chucvu.Text = row["CHUCVU"].ToString();
                    txt_gioitinh.Text = row["GIOITINH"].ToString();
                    txt_tinhtranghonnhan.Text = row["TINHTRANGHONNHAN"].ToString();
                    txt_dantoc.Text = row["DANTOC"].ToString();
                    txt_ngaysinh.Text = row["NGAYSINH"].ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            hienthidulieu();
        }
    }
}
