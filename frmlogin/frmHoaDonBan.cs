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
using System.IO;
using OfficeOpenXml;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace frmlogin
{
    public partial class frmHoaDonBan : Form
    {
        private DataTable tblCTHDB;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            //btnXoa.Enabled = false;
            txtMaHDBan.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhach.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
          //  mtpDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            Funtions.FillCombo("SELECT MAKH, TENKH FROM KHACHHANG", cboMaKhach, "TENKH", "MAKH");
            cboMaKhach.SelectedIndex = -1;
            Funtions.FillCombo("SELECT MASP, TENSP FROM SANPHAM", cboMaHang, "TENSP", "MASP");
            cboMaHang.SelectedIndex = -1;
         
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoaDon();
                //btnXoa.Enabled = true;
            }
            LoadDataGridView();
            btnInHD.Enabled = false;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MASP, TENSP, DBO.CHITIETHOADON.SOLUONG, DONGIA, GIAMGIA,THANHTIEN FROM CHITIETHOADON,SANPHAM WHERE MAHD = N'" + txtMaHDBan.Text + "' AND CHITIETHOADON.MSP=SANPHAM.MASP";
            tblCTHDB = Funtions.GetDataTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;

        }
        //NẠP CHI tiết hóa đơn
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT MANV FROM HOADON WHERE MAHD = N'" + txtMaHDBan.Text + "'";
            cboMaKhach.SelectedValue = Funtions.GetFieldValues(str);
            str = "SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txtMaHDBan.Text + "'";
            txtTongTien.Text = Funtions.GetFieldValues(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string str = "SELECT TENNV FROM NHANVIEN WHERE MANV='" + Dangnhap.ID + "'";
             txt_manhanvien.Text = Dangnhap.ID;
            txtTenNhanVien.Text= Funtions.GetFieldValues(str);
            //btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHDBan.Enabled = false;
            txtMaHDBan.Text = Funtions.CreateKey().ToString();
            LoadDataGridView();
            DateTime dt = DateTime.Now;
            txt_ngayban.Text = dt.ToString("dd/MM/yyyy");
            txtTenKhach.Enabled = txtTenNhanVien.Enabled = txtDiaChi.Enabled =  txt_ngayban.Enabled = false;
            
        }
        //nạp các giá trị về mặc định
        private void ResetValues()
        {
          
            txt_ngayban.Text = "";
            cboMaKhach.Text = "";
            txtTongTien.Text = "0";
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, Tongmoi=0;
        
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
           
                 if (cboMaKhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKhach.Focus();
                    return;
                }
                sql = "INSERT INTO HOADON VALUES ('" + txtMaHDBan.Text + "','" +
                       cboMaKhach.Text + "','" + txt_manhanvien.Text + "','" +
                        txt_ngayban.Text + "'," + txtTongTien.Text + ")";
                Funtions.RunSQL(sql);
            
            // Lưu thông tin của các mặt hàng
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            if (txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return;
            }
            sql = "SELECT MSP FROM CHITIETHOADON WHERE MSP=N'" + cboMaHang.Text + "' AND MAHD = N'" + txtMaHDBan.Text.Trim() + "'";
            if (Funtions.CheckKey(sql))

            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Funtions.GetFieldValues("SELECT SOLUONG FROM SANPHAM WHERE MASP = N'" + cboMaHang.Text + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO CHITIETHOADON VALUES('" + txtMaHDBan.Text + "','" + cboMaHang.Text + "'," + txtSoLuong.Text + "," + txtDonGiaBan.Text + "," + txtGiamGia.Text + "," + txtThanhTien.Text + ")";
            Funtions.RunSQL(sql);
            LoadDataGridView();
           
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE SANPHAM SET SOLUONG =" + SLcon + " WHERE MASP ='" + cboMaHang.Text + "'";
            Funtions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán

            Tongmoi = Tongmoi+ Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE HOADON SET TONGTIEN =" + Tongmoi + " WHERE MAHD = N'" + txtMaHDBan.Text + "'";
            Funtions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            ResetValuesHang();
            ResetValues();
            //btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInHD.Enabled = true;
        }
        // bổ xung reset phần mặt hàng
        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
    
           
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

       

        private void cboMaHD_DropDown(object sender, EventArgs e)
        {
            Funtions.FillCombo("SELECT MAHD FROM HOADON", cboMaHD, "MAHD", "MAHD");
            cboMaHD.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHD.Focus();
                return;
            }
            txtMaHDBan.Text = cboMaHD.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            //btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            cboMaHD.SelectedIndex = -1;
            btnInHD.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
            {
                e.Handled = false;
            }    
            else
            {
                e.Handled = true;
            }
        }

     

        
        private void btnInHD_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng tiện lợi ABC";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Sài Gòn";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0000000000";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT DBO.HOADON.MAHD, NGAYBAN, TONGTIEN,TENKH, DBO.KHACHHANG.DIACHI,DBO.KHACHHANG.SDT, TENNV FROM HOADON , KHACHHANG , NHANVIEN WHERE  MAHD = '" + txtMaHDBan.Text + "' AND HOADON.MAKH = KHACHHANG.MAKH AND HOADON.MANV = NHANVIEN.MANV";
            tblThongtinHD = Funtions.GetDataTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT MASP, TENSP, DBO.CHITIETHOADON.SOLUONG, DONGIA, GIAMGIA,THANHTIEN FROM CHITIETHOADON,SANPHAM WHERE MAHD = N'" + txtMaHDBan.Text + "' AND CHITIETHOADON.MSP=SANPHAM.MASP";
            tblThongtinHang = Funtions.GetDataTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
           //DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            //exRange.Range["A1:C1"].Value = "Sài gòn, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            //exRange.Range["A2:C2"].MergeCells = true;
            //exRange.Range["A2:C2"].Font.Italic = true;
            //exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            //exRange.Range["A6:C6"].MergeCells = true;
            //exRange.Range["A6:C6"].Font.Italic = true;
            //exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            //exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvHDBanHang.CurrentRow.Cells["MASP"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["SOLUONG"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["THANHTIEN"].Value.ToString());
                sql = "DELETE CHITIETHOADON WHERE MAHD=N'" + txtMaHDBan.Text + "' AND MSP = N'" + MaHangxoa + "'";
                Funtions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Funtions.GetFieldValues("SELECT SOLUONG FROM SANPHAM WHERE MASP = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE SANPHAM SET SOLUONG =" + slcon + " WHERE MASP= N'" + MaHangxoa + "'";
                Funtions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Funtions.GetFieldValues("SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txtMaHDBan.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HOADON SET TONGTIEN =" + tongmoi + " WHERE MAHD = N'" + txtMaHDBan.Text + "'";
                Funtions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                LoadDataGridView();
            }
        }

        private void txtMaHDBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

 

        private void cboMaHang_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboMaKhach_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string str;
            string a = cboMaKhach.SelectedText.ToString();
            if (cboMaKhach.Text == "")
            {
                txtTenKhach.Text = "";
                txtDiaChi.Text = "";
                txt_dienthoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TENKH from KHACHHANG where MAKH = N'" + a + "'";
            txtTenKhach.Text = Funtions.GetFieldValues(str).ToString();
            str = "Select DIACHI from KHACHHANG where MAKH = N'" + a + "'";
            txtDiaChi.Text = Funtions.GetFieldValues(str);
            str = "Select SDT from KHACHHANG where MAKH = N'" + a + "'";
            txt_dienthoai.Text = Funtions.GetFieldValues(str).ToString();
        }

        private void cboMaHang_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string str;
            string a = cboMaHang.SelectedText.ToString();
            if (cboMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGiaBan.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TENSP FROM SANPHAM WHERE MASP =N'" + a+ "'";
            txtTenHang.Text = Funtions.GetFieldValues(str);
            str = "SELECT DG FROM SANPHAM WHERE MASP =N'" + a + "'";
            txtDonGiaBan.Text = Funtions.GetFieldValues(str);
        }

        private void dgvHDBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
