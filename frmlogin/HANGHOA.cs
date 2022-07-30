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

namespace frmlogin
{
    public partial class frmHANGHOA : DevExpress.XtraEditors.XtraForm
    {

        SqlConnection connection;
        SqlCommand command;

        string str = ConfigurationManager.ConnectionStrings["frmlogin.Properties.Settings.Setting"].ConnectionString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from LOAISANPHAM ";
            // command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView_HANGHOA.DataSource = table;
        }

        public frmHANGHOA()
        {
            InitializeComponent();
        }

        private void frmHANGHOA_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void dataGridView_HANGHOA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i =dataGridView_HANGHOA.CurrentRow.Index;
            txtMAHANG.Text = dataGridView_HANGHOA.Rows[i].Cells[0].Value.ToString();
            txtTENHANG.Text = dataGridView_HANGHOA.Rows[i].Cells[1].Value.ToString();
           
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
           
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO LOAISANPHAM VALUES ('" + txtMAHANG.Text + "','" + txtTENHANG.Text + "')";
               
                if (string.IsNullOrEmpty(txtMAHANG.Text))
                {
                    MessageBox.Show("Kiểm tra lại Mã hàng hóa", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
                if (string.IsNullOrEmpty(txtTENHANG.Text))
                {
                    MessageBox.Show("Kiểm tra lại Tên hàng hóa", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
                }
                MessageBox.Show("Đã Lưu", "Thông báo");
            command.ExecuteNonQuery();
            LoadData();
               

            btnLAMMOI.Visible = true;

        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE LOAISANPHAM SET TENLOAISANPHAM ='" + txtTENHANG.Text + "' WHERE MALOAISP = " + txtMAHANG.Text + " ";
                command.ExecuteNonQuery();
                MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                MessageBox.Show("Đã Lưu", "Thông báo");
                LoadData();
                txtMAHANG.Text = "";
                txtTENHANG.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM LOAISANPHAM WHERE MALOAISP ='" + txtMAHANG.Text + "'";

            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Đã Lưu", "Thông báo");
                command.ExecuteNonQuery();
                LoadData();
                txtMAHANG.Text = "";
                txtTENHANG.Text = "";
            }
           

        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView_HANGHOA.Rows.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView_HANGHOA.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView_HANGHOA.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_HANGHOA.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView_HANGHOA.Rows[i].Cells[j].Value;
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
                dataGridView_HANGHOA.DataSource = dataTable;

            }
        }

        
        private void btnXUAT_Click(object sender, EventArgs e)
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

        private void btnLAMMOI_Click(object sender, EventArgs e)
        {
            txtMAHANG.Text = "";
            txtTENHANG.Text = "";
            btnLAMMOI.Visible = false;
        }

        private void dataGridView_HANGHOA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}