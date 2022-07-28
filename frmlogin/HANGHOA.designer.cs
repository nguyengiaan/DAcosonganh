namespace frmlogin
{
    partial class frmHANGHOA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLAMMOI = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnXUAT = new System.Windows.Forms.Button();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.txtTENHANG = new System.Windows.Forms.TextBox();
            this.txtMAHANG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_HANGHOA = new System.Windows.Forms.DataGridView();
            this.MALOAISP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HANGHOA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnLAMMOI);
            this.panel1.Controls.Add(this.btnTHEM);
            this.panel1.Controls.Add(this.btnSUA);
            this.panel1.Controls.Add(this.btnXOA);
            this.panel1.Controls.Add(this.btnXUAT);
            this.panel1.Controls.Add(this.txtTIMKIEM);
            this.panel1.Controls.Add(this.txtTENHANG);
            this.panel1.Controls.Add(this.txtMAHANG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Location = new System.Drawing.Point(1074, 0);
            this.btnLAMMOI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.Size = new System.Drawing.Size(88, 47);
            this.btnLAMMOI.TabIndex = 9;
            this.btnLAMMOI.Text = "Làm mới";
            this.btnLAMMOI.UseVisualStyleBackColor = true;
            this.btnLAMMOI.Click += new System.EventHandler(this.btnLAMMOI_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTHEM.Location = new System.Drawing.Point(810, 0);
            this.btnTHEM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(88, 47);
            this.btnTHEM.TabIndex = 8;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSUA.Location = new System.Drawing.Point(898, 0);
            this.btnSUA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(88, 47);
            this.btnSUA.TabIndex = 7;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXOA.Location = new System.Drawing.Point(986, 0);
            this.btnXOA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(88, 47);
            this.btnXOA.TabIndex = 6;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnXUAT
            // 
            this.btnXUAT.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXUAT.Location = new System.Drawing.Point(1074, 0);
            this.btnXUAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXUAT.Name = "btnXUAT";
            this.btnXUAT.Size = new System.Drawing.Size(88, 47);
            this.btnXUAT.TabIndex = 1;
            this.btnXUAT.Text = "Xuất";
            this.btnXUAT.UseVisualStyleBackColor = true;
            this.btnXUAT.Click += new System.EventHandler(this.btnXUAT_Click);
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTIMKIEM.Location = new System.Drawing.Point(588, 9);
            this.txtTIMKIEM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(147, 23);
            this.txtTIMKIEM.TabIndex = 5;
            // 
            // txtTENHANG
            // 
            this.txtTENHANG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTENHANG.Location = new System.Drawing.Point(321, 10);
            this.txtTENHANG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTENHANG.Multiline = true;
            this.txtTENHANG.Name = "txtTENHANG";
            this.txtTENHANG.Size = new System.Drawing.Size(161, 25);
            this.txtTENHANG.TabIndex = 4;
            // 
            // txtMAHANG
            // 
            this.txtMAHANG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMAHANG.Location = new System.Drawing.Point(87, 9);
            this.txtMAHANG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMAHANG.Multiline = true;
            this.txtMAHANG.Name = "txtMAHANG";
            this.txtMAHANG.Size = new System.Drawing.Size(136, 24);
            this.txtMAHANG.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(490, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng";
            // 
            // dataGridView_HANGHOA
            // 
            this.dataGridView_HANGHOA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_HANGHOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HANGHOA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAISP,
            this.TENLOAISANPHAM});
            this.dataGridView_HANGHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HANGHOA.Location = new System.Drawing.Point(0, 47);
            this.dataGridView_HANGHOA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_HANGHOA.Name = "dataGridView_HANGHOA";
            this.dataGridView_HANGHOA.RowHeadersWidth = 51;
            this.dataGridView_HANGHOA.Size = new System.Drawing.Size(1162, 326);
            this.dataGridView_HANGHOA.TabIndex = 1;
            this.dataGridView_HANGHOA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HANGHOA_CellClick);
            this.dataGridView_HANGHOA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HANGHOA_CellContentClick);
            // 
            // MALOAISP
            // 
            this.MALOAISP.DataPropertyName = "MALOAISP";
            this.MALOAISP.HeaderText = "Mã sản phẩm";
            this.MALOAISP.MinimumWidth = 6;
            this.MALOAISP.Name = "MALOAISP";
            this.MALOAISP.Width = 150;
            // 
            // TENLOAISANPHAM
            // 
            this.TENLOAISANPHAM.DataPropertyName = "TENLOAISANPHAM";
            this.TENLOAISANPHAM.HeaderText = "Tên loại sản phẩm";
            this.TENLOAISANPHAM.MinimumWidth = 6;
            this.TENLOAISANPHAM.Name = "TENLOAISANPHAM";
            this.TENLOAISANPHAM.Width = 150;
            // 
            // frmHANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 373);
            this.Controls.Add(this.dataGridView_HANGHOA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHANGHOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HANGHOA";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmHANGHOA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HANGHOA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.TextBox txtTENHANG;
        private System.Windows.Forms.TextBox txtMAHANG;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnXUAT;
        private System.Windows.Forms.DataGridView dataGridView_HANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISANPHAM;
        private System.Windows.Forms.Button btnLAMMOI;
    }
}