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
using frmlogin.Class;
namespace frmlogin
{
    public partial class dssanpham : DevExpress.XtraEditors.XtraForm
    {
        public dssanpham()
        {
            InitializeComponent();
        }
        public void hienthidulieu()
        {
            string str = "SELECT * FROM SANPHAM";
            dt_danhsachsanpham.DataSource = Funtions.GetDataTable(str);
        }
        private void dt_danhsachsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dssanpham_Load(object sender, EventArgs e)
        {
            hienthidulieu();
            string str = "SELECT MALOAISP FROM LOAISANPHAM";
            Funtions.FillCombo(str, cb_loaisanpham, "MALOAISP", "MALOAISP");
            cb_loaisanpham.SelectedIndex = -1;
            txt_donvitinh.Text = "nghìn";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM SANPHAM";
            txt_masanpham.Text = Funtions.CreateKey1(str).ToString();
            
            txt_donvitinh.Enabled = false;
            txt_masanpham.Enabled = false;
        }
        public void reset()
        {
            txt_masanpham.Text = "";
            txt_dongia.Text = "";
            txt_soluong.Text = "";
            txt_tensanpham.Text = "";
            cb_loaisanpham.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO SANPHAM(MASP,TENSP,DVT,DG,MALOAISP,SOLUONG) VALUES ('" + txt_masanpham.Text + "','" + txt_tensanpham.Text + "','" + txt_donvitinh.Text + "','" + txt_dongia.Text + "','" + cb_loaisanpham.Text + "','" + txt_soluong.Text + "')";
            Funtions.RunSQL(str);
            hienthidulieu();
            reset();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }
        int vt = -1;
        private void dt_danhsachsanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_danhsachsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dia = MessageBox.Show("bạn có đồng ý xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dia == DialogResult.Yes)
            {

                int a = Convert.ToInt32(dt_danhsachsanpham.CurrentRow.Cells["MASP"].Value);
                string str1 = "DELETE CHITIETHOADON WHERE MSP='" + a + "'";
                Funtions.RunSQL(str1);
                string str = "DELETE SANPHAM WHERE MASP='" + a + "'";
                Funtions.RunSQL(str);
                hienthidulieu();

            }
        }

        private void dt_danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if(vt==-1)
            {
                return;
            }
            string str = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = Funtions.GetDataTable(str);
            try
            {
                DataRow dtr = dt.Rows[vt];
                txt_dongia.Text = dtr["DG"].ToString();
                txt_tensanpham.Text = dtr["TENSP"].ToString();
                txt_soluong.Text = dtr["SOLUONG"].ToString();
                txt_masanpham.Text = dtr["MASP"].ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

              
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string str = "UPDATE SANPHAM SET TENSP='" + txt_tensanpham.Text + "',DG='" + txt_dongia.Text + "',SOLUONG='" + txt_soluong.Text + "'where MASP='"+txt_masanpham.Text+"'";
            try {
                Funtions.RunSQL(str);
                hienthidulieu();
                MessageBox.Show("cập nhật thành công");

                
            }catch
            {
                MessageBox.Show("cập nhật thất bại");
            }
          
        }
    }
    }