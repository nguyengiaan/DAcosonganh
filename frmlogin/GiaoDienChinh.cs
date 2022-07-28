using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmlogin
{
    public partial class GiaoDienChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string username = "";
        public string quyen = "ADMIN";
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void bar_taikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            TaiKhoan tk = new TaiKhoan();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_danhsachtaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            Danhsachnhanvien tk = new Danhsachnhanvien();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            if(username!=quyen)
            {
                bar_danhsachtaikhoan.Enabled = false;
            }    
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            frmKHACHHANG tk = new frmKHACHHANG();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_hoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            frmHoaDonBan tk = new frmHoaDonBan();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_hanghoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
          frmHANGHOA tk = new frmHANGHOA();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_sanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            dssanpham tk = new dssanpham();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_trangchu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pn_ql.Controls.Clear();
            pn_ql.Dock = DockStyle.Fill;
            trangchu tk = new trangchu();
            tk.Dock = DockStyle.Fill;
            tk.TopLevel = false;
            pn_ql.Controls.Add(tk);
            tk.Show();
        }

        private void bar_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
           
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }
    }
}