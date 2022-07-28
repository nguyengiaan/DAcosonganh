namespace frmlogin
{
    partial class Danhsachnhanvien
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
            this.Dtquanlynhanvien = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timkiemten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_quayve = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtquanlynhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtquanlynhanvien
            // 
            this.Dtquanlynhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtquanlynhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Dtquanlynhanvien.Location = new System.Drawing.Point(12, 12);
            this.Dtquanlynhanvien.Name = "Dtquanlynhanvien";
            this.Dtquanlynhanvien.RowHeadersWidth = 51;
            this.Dtquanlynhanvien.RowTemplate.Height = 24;
            this.Dtquanlynhanvien.Size = new System.Drawing.Size(681, 290);
            this.Dtquanlynhanvien.TabIndex = 0;
            this.Dtquanlynhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtquanlynhanvien_CellClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MANV";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENNV";
            this.Column1.HeaderText = "Tên nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DIACHI";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CHUCVU";
            this.Column4.HeaderText = "Chức vụ ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.txt_chucvu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sodienthoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tennhanvien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_manhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(707, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_sua
            // 
            this.bt_sua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_sua.Image = global::frmlogin.Properties.Resources.updateicon;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(310, 227);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(96, 38);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "sửa";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_xoa.Image = global::frmlogin.Properties.Resources.deleteicon;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(184, 227);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(96, 38);
            this.bt_xoa.TabIndex = 12;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_them.Image = global::frmlogin.Properties.Resources.addicon3;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(38, 227);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(120, 38);
            this.bt_them.TabIndex = 11;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(143, 183);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(286, 22);
            this.txt_chucvu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chức vụ";
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(143, 143);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(286, 22);
            this.txt_sodienthoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(143, 103);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(286, 22);
            this.txt_diachi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(143, 63);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(286, 22);
            this.txt_tennhanvien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên nhân viên:";
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(143, 27);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(286, 22);
            this.txt_manhanvien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txt_timkiemten
            // 
            this.txt_timkiemten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiemten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiemten.Location = new System.Drawing.Point(161, 316);
            this.txt_timkiemten.Name = "txt_timkiemten";
            this.txt_timkiemten.Size = new System.Drawing.Size(330, 30);
            this.txt_timkiemten.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên nhân viên:";
            // 
            // bt_quayve
            // 
            this.bt_quayve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_quayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quayve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_quayve.Image = global::frmlogin.Properties.Resources.Industry_Return_icon;
            this.bt_quayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quayve.Location = new System.Drawing.Point(653, 312);
            this.bt_quayve.Name = "bt_quayve";
            this.bt_quayve.Size = new System.Drawing.Size(48, 38);
            this.bt_quayve.TabIndex = 15;
            this.bt_quayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_quayve.UseVisualStyleBackColor = true;
            this.bt_quayve.Click += new System.EventHandler(this.bt_quayve_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_timkiem.Image = global::frmlogin.Properties.Resources.search_icon;
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(497, 312);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(147, 38);
            this.bt_timkiem.TabIndex = 14;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // Danhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 371);
            this.Controls.Add(this.bt_quayve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_timkiemten);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dtquanlynhanvien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Danhsachnhanvien";
            this.Text = "Danhsachnhanvien";
            this.Load += new System.EventHandler(this.Danhsachnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtquanlynhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtquanlynhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_timkiemten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button bt_quayve;
    }
}