﻿namespace DoAnQLBV.Views
{
    partial class frmLoaiXetNghiem
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
            this.pnlDanhSachLoaiXN = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grbDanhSachLoaiXN = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLoaiXN = new System.Windows.Forms.DataGridView();
            this.MaLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaLXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLyLoaiXN = new System.Windows.Forms.GroupBox();
            this.cmbHide = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLoaiXN = new System.Windows.Forms.TextBox();
            this.txtGiaLoaiXN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiXN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachLoaiXN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiXN)).BeginInit();
            this.grbQuanLyLoaiXN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDanhSachLoaiXN
            // 
            this.pnlDanhSachLoaiXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDanhSachLoaiXN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachLoaiXN.Location = new System.Drawing.Point(490, 330);
            this.pnlDanhSachLoaiXN.Name = "pnlDanhSachLoaiXN";
            this.pnlDanhSachLoaiXN.Size = new System.Drawing.Size(1017, 302);
            this.pnlDanhSachLoaiXN.TabIndex = 146;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(785, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(304, 22);
            this.label12.TabIndex = 145;
            this.label12.Text = "DANH SÁCH LOẠI XÉT NGHIỆM";
            // 
            // grbDanhSachLoaiXN
            // 
            this.grbDanhSachLoaiXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbDanhSachLoaiXN.Controls.Add(this.dgvDanhSachLoaiXN);
            this.grbDanhSachLoaiXN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachLoaiXN.Location = new System.Drawing.Point(478, 59);
            this.grbDanhSachLoaiXN.Name = "grbDanhSachLoaiXN";
            this.grbDanhSachLoaiXN.Size = new System.Drawing.Size(1034, 250);
            this.grbDanhSachLoaiXN.TabIndex = 144;
            this.grbDanhSachLoaiXN.TabStop = false;
            // 
            // dgvDanhSachLoaiXN
            // 
            this.dgvDanhSachLoaiXN.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiXN.AllowUserToDeleteRows = false;
            this.dgvDanhSachLoaiXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiXN.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachLoaiXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiXN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiXN,
            this.TenLoaiXN,
            this.GiaLXN,
            this.Hide});
            this.dgvDanhSachLoaiXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLoaiXN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachLoaiXN.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachLoaiXN.Name = "dgvDanhSachLoaiXN";
            this.dgvDanhSachLoaiXN.ReadOnly = true;
            this.dgvDanhSachLoaiXN.Size = new System.Drawing.Size(1028, 225);
            this.dgvDanhSachLoaiXN.TabIndex = 60;
            // 
            // MaLoaiXN
            // 
            this.MaLoaiXN.DataPropertyName = "MaLoaiXN";
            this.MaLoaiXN.HeaderText = "Mã Loại XN";
            this.MaLoaiXN.Name = "MaLoaiXN";
            this.MaLoaiXN.ReadOnly = true;
            // 
            // TenLoaiXN
            // 
            this.TenLoaiXN.DataPropertyName = "TenLoaiXN";
            this.TenLoaiXN.HeaderText = "Tên Loại XN";
            this.TenLoaiXN.Name = "TenLoaiXN";
            this.TenLoaiXN.ReadOnly = true;
            // 
            // GiaLXN
            // 
            this.GiaLXN.DataPropertyName = "GiaLXN";
            this.GiaLXN.HeaderText = "Giá Loại XN";
            this.GiaLXN.Name = "GiaLXN";
            this.GiaLXN.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.DataPropertyName = "Hide";
            this.Hide.HeaderText = "Tình Trạng";
            this.Hide.Name = "Hide";
            this.Hide.ReadOnly = true;
            // 
            // grbQuanLyLoaiXN
            // 
            this.grbQuanLyLoaiXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbQuanLyLoaiXN.Controls.Add(this.cmbHide);
            this.grbQuanLyLoaiXN.Controls.Add(this.label13);
            this.grbQuanLyLoaiXN.Controls.Add(this.label5);
            this.grbQuanLyLoaiXN.Controls.Add(this.txtTenLoaiXN);
            this.grbQuanLyLoaiXN.Controls.Add(this.txtGiaLoaiXN);
            this.grbQuanLyLoaiXN.Controls.Add(this.label7);
            this.grbQuanLyLoaiXN.Controls.Add(this.label2);
            this.grbQuanLyLoaiXN.Controls.Add(this.txtMaLoaiXN);
            this.grbQuanLyLoaiXN.Controls.Add(this.label6);
            this.grbQuanLyLoaiXN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLyLoaiXN.Location = new System.Drawing.Point(-2, 59);
            this.grbQuanLyLoaiXN.Name = "grbQuanLyLoaiXN";
            this.grbQuanLyLoaiXN.Size = new System.Drawing.Size(476, 269);
            this.grbQuanLyLoaiXN.TabIndex = 137;
            this.grbQuanLyLoaiXN.TabStop = false;
            // 
            // cmbHide
            // 
            this.cmbHide.FormattingEnabled = true;
            this.cmbHide.Location = new System.Drawing.Point(108, 225);
            this.cmbHide.Name = "cmbHide";
            this.cmbHide.Size = new System.Drawing.Size(137, 27);
            this.cmbHide.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 93;
            this.label13.Text = "Tình Trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 85;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txtTenLoaiXN
            // 
            this.txtTenLoaiXN.Location = new System.Drawing.Point(141, 117);
            this.txtTenLoaiXN.Name = "txtTenLoaiXN";
            this.txtTenLoaiXN.Size = new System.Drawing.Size(125, 27);
            this.txtTenLoaiXN.TabIndex = 80;
            // 
            // txtGiaLoaiXN
            // 
            this.txtGiaLoaiXN.Location = new System.Drawing.Point(141, 150);
            this.txtGiaLoaiXN.Name = "txtGiaLoaiXN";
            this.txtGiaLoaiXN.Size = new System.Drawing.Size(125, 27);
            this.txtGiaLoaiXN.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tên Loại XN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Giá Loại XN";
            // 
            // txtMaLoaiXN
            // 
            this.txtMaLoaiXN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaLoaiXN.Enabled = false;
            this.txtMaLoaiXN.Location = new System.Drawing.Point(132, 52);
            this.txtMaLoaiXN.Name = "txtMaLoaiXN";
            this.txtMaLoaiXN.Size = new System.Drawing.Size(125, 27);
            this.txtMaLoaiXN.TabIndex = 92;
            this.txtMaLoaiXN.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "Mã Loại XN :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.Location = new System.Drawing.Point(292, 373);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 50);
            this.btnLuu.TabIndex = 138;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageIndex = 2;
            this.btnSua.Location = new System.Drawing.Point(106, 373);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 50);
            this.btnSua.TabIndex = 139;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 1;
            this.btnXoa.Location = new System.Drawing.Point(196, 373);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 50);
            this.btnXoa.TabIndex = 140;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.ImageIndex = 4;
            this.btnHuy.Location = new System.Drawing.Point(379, 373);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 50);
            this.btnHuy.TabIndex = 142;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.ImageIndex = 0;
            this.btnThemMoi.Location = new System.Drawing.Point(6, 373);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 50);
            this.btnThemMoi.TabIndex = 143;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.Control;
            this.btnHide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHide.ImageIndex = 6;
            this.btnHide.Location = new System.Drawing.Point(226, 442);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 49);
            this.btnHide.TabIndex = 135;
            this.btnHide.Text = "Ẩn ";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHide.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.ImageIndex = 5;
            this.btnFind.Location = new System.Drawing.Point(106, 442);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(114, 49);
            this.btnFind.TabIndex = 136;
            this.btnFind.Text = "Tìm kiếm ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 141;
            this.label1.Text = "QUẢN LÝ LOẠI XÉT NGHIỆM";
            // 
            // frmLoaiXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 660);
            this.Controls.Add(this.pnlDanhSachLoaiXN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbDanhSachLoaiXN);
            this.Controls.Add(this.grbQuanLyLoaiXN);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiXetNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiXetNghiem";
            this.Load += new System.EventHandler(this.frmLoaiXetNghiem_Load);
            this.grbDanhSachLoaiXN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiXN)).EndInit();
            this.grbQuanLyLoaiXN.ResumeLayout(false);
            this.grbQuanLyLoaiXN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDanhSachLoaiXN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbDanhSachLoaiXN;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiXN;
        private System.Windows.Forms.GroupBox grbQuanLyLoaiXN;
        private System.Windows.Forms.ComboBox cmbHide;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenLoaiXN;
        private System.Windows.Forms.TextBox txtGiaLoaiXN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiXN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiXN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaLXN;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Hide;
    }
}