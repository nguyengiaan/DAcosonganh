using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using frmlogin.Class;

namespace frmlogin
{
    public partial class frmKHACHHANG : DevExpress.XtraEditors.XtraForm
    {

        SqlConnection connection;
        SqlCommand command;
        string s = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHACHHANG " ;
           // command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear(); 
            adapter.Fill(table);
            dataGridView_KHACHHANG.DataSource = table;
        }




        public frmKHACHHANG()
        {
            InitializeComponent();
            
        }

        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            Lockcontrol();
            connection = new SqlConnection(s);
            connection.Open();
            LoadData();

            
        }





        //private void dataGridView_KHACHHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
           
        //    int i;
        //    i = dataGridView_KHACHHANG.CurrentRow.Index;
        //    txtMAKH.Text = dataGridView_KHACHHANG.Rows[i].Cells[0].Value.ToString();
        //    txtTENKH.Text = dataGridView_KHACHHANG.Rows[i].Cells[1].Value.ToString();
        //    txtDIACHI.Text = dataGridView_KHACHHANG.Rows[i].Cells[2].Value.ToString();
        //    txtSDT.Text = dataGridView_KHACHHANG.Rows[i].Cells[3].Value.ToString();
        //    txtEMAIL.Text = dataGridView_KHACHHANG.Rows[i].Cells[4].Value.ToString();


        //}



        
        public void checkData()
        {
            if (txtMAKH.Text=="")
            {
                MessageBox.Show("Kiểm tra lại Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAKH.Focus();
                return;
            }

            if (txtTENKH.Text=="")
            {
                MessageBox.Show("Kiểm tra lại Tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENKH.Focus();
                return;
            }

            if (txtDIACHI.Text=="")
            {
                MessageBox.Show("Kiểm tra lại Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDIACHI.Focus();
                return;
            }
            if (txtSDT.Text=="")
            {
                MessageBox.Show("Kiểm tra lại số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            if (txtEMAIL.Text=="")
            {
                MessageBox.Show("Kiểm tra lại Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEMAIL.Focus();
                return;
            }
        }


        /*
        public class TBLKHACHHANG
        {
            public int  MAKH { get; set; }
            public string TENKH { get; set; }
            public string DIACHI { get; set; }
            public string SDT { get; set; }
            public string EMAIL { get; set; }


        }
        TBLKHACHHANG KH = new TBLKHACHHANG();
        */

        void btnTHEM_Click(object sender, EventArgs e)
        {
            checkData();
            try
            { 
               command = connection.CreateCommand();
                command.CommandText = "INSERT INTO KHACHHANG VALUES ('" + txtMAKH.Text + "',N'" + txtTENKH.Text + "',N'" + txtDIACHI.Text + "',N'" + txtSDT.Text + "',N'" + txtEMAIL.Text + "')";
                command.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDIACHI.Text = "";
                txtEMAIL.Text = "";
                txtMAKH.Text = "";
                txtSDT.Text = "";
                txtTENKH.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Lockcontrol()
        {
            txtDIACHI.ReadOnly=true;
            txtEMAIL.ReadOnly=true;
            txtMAKH.ReadOnly=true;
            txtSDT.ReadOnly=true;
            txtTENKH.ReadOnly = true;

            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnSUA.Enabled = false;
           

        }

        public void Unlockcontrol()
        {
            txtDIACHI.ReadOnly = false;
            txtEMAIL.ReadOnly = false;
            txtMAKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTENKH.ReadOnly = false;


            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnSUA.Enabled = true;
           
        }


        private void btnXOA_Click(object sender, EventArgs e)
        {
            
            command = connection.CreateCommand();
            command.CommandText = "delete from KHACHHANG WHERE MAKH = '"+txtMAKH.Text+"' " ;
            command.ExecuteNonQuery();

            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                checkData();
                LoadData();
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtDIACHI.Text = "";
            txtEMAIL.Text = "";
            txtMAKH.Text = "";
            txtSDT.Text = "";
            txtTENKH.Text = "";
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {

          //  MessageBox.Show("Chưa chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );          
            command = connection.CreateCommand();
            command.CommandText = "UPDATE KHACHHANG SET TENKH = '"+txtTENKH.Text+ "',DIACHI = '" + txtDIACHI.Text + "', SDT ='" + txtSDT.Text + "',EMAIL ='" + txtEMAIL.Text + "'  WHERE MAKH = " + txtMAKH.Text + " ";
            command.ExecuteNonQuery();
            if (MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                checkData();
            LoadData();
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDIACHI.Text = "";
            txtEMAIL.Text = "";
            txtMAKH.Text = "";
            txtSDT.Text = "";
            txtTENKH.Text = "";


        }

        private void btnMOKHOA_Click(object sender, EventArgs e)
        {
            Unlockcontrol();

            MessageBox.Show("Đã mở khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            btnMOKHOA.Visible= false;
           

           
        }

        

        private void btnLAMMOI_Click(object sender, EventArgs e)
        {
            txtDIACHI.Text = "";
            txtEMAIL.Text = "";
            txtMAKH.Text = "";
            txtSDT.Text = "";
            txtTENKH.Text = "";

        }


        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView_KHACHHANG.Rows.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView_KHACHHANG.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView_KHACHHANG.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_KHACHHANG.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView_KHACHHANG.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorkSheet = excelPackage.Workbook.Worksheets[0];
                System.Data.DataTable dataTable = new System.Data.DataTable();
                for (int i = excelWorkSheet.Dimension.Start.Column; i <= excelWorkSheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorkSheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorkSheet.Dimension.Start.Row + 1; i <= excelWorkSheet.Dimension.End.Row; i++)
                {
                    List<string> listRow = new List<string>();
                    for (int j = excelWorkSheet.Dimension.Start.Column; j <= excelWorkSheet.Dimension.End.Column; j++)
                    {
                        listRow.Add(excelWorkSheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRow.ToArray());
                }
                dataGridView_KHACHHANG.DataSource = dataTable;

            }
        }


        private void btnXUATEXCEL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogv = new OpenFileDialog();
            openFileDialogv.Title = "Import Excel";
            openFileDialogv.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|.xls";
            if (openFileDialogv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialogv.FileName);
                    MessageBox.Show("Import Complete!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import Uncomplete! \n" + ex.Message);
                }
            }
        }

        private void dataGridView_KHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_KHACHHANG.CurrentRow.Index;
            txtMAKH.Text = dataGridView_KHACHHANG.Rows[i].Cells[0].Value.ToString();
            txtTENKH.Text = dataGridView_KHACHHANG.Rows[i].Cells[1].Value.ToString();
            txtDIACHI.Text = dataGridView_KHACHHANG.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView_KHACHHANG.Rows[i].Cells[3].Value.ToString();
            txtEMAIL.Text = dataGridView_KHACHHANG.Rows[i].Cells[4].Value.ToString();

        }

        private void dataGridView_KHACHHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}