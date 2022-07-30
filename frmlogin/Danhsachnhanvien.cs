using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace frmlogin
{
    public partial class Danhsachnhanvien : DevExpress.XtraEditors.XtraForm
    {
        string s = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con;
        DataTable dt;
        public Danhsachnhanvien()
        {
            InitializeComponent();
        }

       
        private void hienthidulieu()
        {
            con = new SqlConnection(s);
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter("SELECT MANV,TENNV,DIACHI,SDT,CHUCVU FROM NHANVIEN ", con);
            dt = new DataTable("Nhanvien");
            dta.Fill(dt);
            Dtquanlynhanvien.DataSource = dt;


        }
        private void Danhsachnhanvien_Load(object sender, EventArgs e)
        {
            hienthidulieu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(s);
            con.Open();
           SqlCommand  command = new SqlCommand();
            try
            {
                command.Connection = con;
                command.CommandText = "INSERT INTO NHANVIEN(MANV,TENNV,DIACHI,SDT,CHUCVU) VALUES (@MANV,@TENNV,@DIACHI,@SDT,@CHUCVU)";
                command.Parameters.Add("@MANV", txt_manhanvien.Text);
                command.Parameters.Add("@TENNV", txt_tennhanvien.Text);
                command.Parameters.Add("@DIACHI", txt_diachi.Text);
                command.Parameters.Add("@SDT", txt_sodienthoai.Text);
                command.Parameters.Add("@CHUCVU", txt_chucvu.Text);
                command.ExecuteNonQuery();
            }catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            hienthidulieu();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("bạn có đồng ý xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia == DialogResult.Yes)
            {
                xoadulieu();
            }
        }
        int vt = -1;
        private void xoadulieu()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu ");
            }
            else
            {
                con = new SqlConnection(s);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "DELETE FROM NHANVIEN WHERE MANV=@MANV ";
                command.Parameters.Add("@MANV", txt_manhanvien.Text);
                command.ExecuteNonQuery();
                hienthidulieu();
            }
        }
        

        private void Dtquanlynhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {

                return;
            }
            try
            {


                DataRow dr = dt.Rows[vt];
                txt_manhanvien.Text = dr["MANV"].ToString();
                txt_tennhanvien.Text = dr["TENNV"].ToString();
                txt_diachi.Text = dr["DIACHI"].ToString();
                txt_sodienthoai.Text = dr["SDT"].ToString();
                txt_chucvu.Text = dr["CHUCVU"].ToString();
            }
            catch
            {
                // MessageBox.Show("Không có dữ liệu");
                return;
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(s);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "UPDATE NHANVIEN SET TENNV=@TENNV,DIACHI=@DIACHI,SDT=@SDT ,CHUCVU=@CHUCVU WHERE MANV=@MANV ";
            command.Parameters.Add("@MANV", txt_manhanvien.Text);
            command.Parameters.Add("@TENNV", txt_tennhanvien.Text);
            command.Parameters.Add("@DIACHI", txt_diachi.Text);
            command.Parameters.Add("@SDT", txt_sodienthoai.Text);
            command.Parameters.Add("@CHUCVU", txt_chucvu.Text);
            command.ExecuteNonQuery();
            hienthidulieu();
        }

        private void bt_quayve_Click(object sender, EventArgs e)
        {
            hienthidulieu();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(s);
            con.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE TENNV='" + txt_timkiemten.Text + "' ", con);
            DataTable dt1 = new DataTable("TimKiem");
            sqlData.Fill(dt1);
            Dtquanlynhanvien.DataSource = dt1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
