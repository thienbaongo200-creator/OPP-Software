namespace QuanLyThuVien.Forms
{
    partial class FrmDocGia
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtHan = new System.Windows.Forms.DateTimePicker();
            this.chkLePhi = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTitle.Location = new System.Drawing.Point(24, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Độc giả và thẻ thư viện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã độc giả:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(140, 72);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(240, 29);
            this.txtMa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(140, 115);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(240, 29);
            this.txtHo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 158);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(240, 29);
            this.txtTen.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(140, 201);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(240, 29);
            this.dtNgaySinh.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phái:";
            // 
            // cboPhai
            // 
            this.cboPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboPhai.Location = new System.Drawing.Point(140, 244);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(240, 29);
            this.cboPhai.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(515, 72);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(240, 29);
            this.txtSDT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(515, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 29);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(515, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 29);
            this.txtEmail.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ảnh 3x4:";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(515, 201);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(240, 29);
            this.txtAnh.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày cấp:";
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayCap.Location = new System.Drawing.Point(515, 244);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(150, 29);
            this.dtNgayCap.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hạn sử dụng:";
            // 
            // dtHan
            // 
            this.dtHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHan.Location = new System.Drawing.Point(515, 287);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(150, 29);
            this.dtHan.TabIndex = 22;
            // 
            // chkLePhi
            // 
            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Location = new System.Drawing.Point(685, 248);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(151, 25);
            this.chkLePhi.TabIndex = 23;
            this.chkLePhi.Text = "Đã đóng lệ phí";
            this.chkLePhi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(950, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 32);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(950, 113);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 32);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnCapThe
            // 
            this.btnCapThe.Location = new System.Drawing.Point(790, 285);
            this.btnCapThe.Name = "btnCapThe";
            this.btnCapThe.Size = new System.Drawing.Size(110, 32);
            this.btnCapThe.TabIndex = 26;
            this.btnCapThe.Text = "Cấp thẻ";
            this.btnCapThe.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(915, 285);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(110, 32);
            this.btnGiaHan.TabIndex = 27;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1040, 285);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 32);
            this.btnLamMoi.TabIndex = 28;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(24, 340);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(1136, 380);
            this.dgvDocGia.TabIndex = 29;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1070, 735);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 790);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnCapThe);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.chkLePhi);
            this.Controls.Add(this.dtHan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtNgayCap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPhai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Độc giả và thẻ";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.btnCapThe.Click += new System.EventHandler(this.btnCapThe_Click);
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtHan;
        private System.Windows.Forms.CheckBox chkLePhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Button btnDong;
    }
}