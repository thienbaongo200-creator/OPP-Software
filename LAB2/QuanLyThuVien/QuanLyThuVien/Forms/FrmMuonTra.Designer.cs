namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.labelDocGia = new System.Windows.Forms.Label();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMuon);
            this.tabs.Controls.Add(this.tabTra);
            this.tabs.Location = new System.Drawing.Point(14, 14);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1182, 695);
            this.tabs.TabIndex = 0;
            // 
            // tabMuon
            // 
            this.tabMuon.Controls.Add(this.btnLapPhieu);
            this.tabMuon.Controls.Add(this.dgvSachChon);
            this.tabMuon.Controls.Add(this.label5);
            this.tabMuon.Controls.Add(this.btnBoSach);
            this.tabMuon.Controls.Add(this.btnThemSach);
            this.tabMuon.Controls.Add(this.dgvSachCon);
            this.tabMuon.Controls.Add(this.label4);
            this.tabMuon.Controls.Add(this.dtHenTra);
            this.tabMuon.Controls.Add(this.label3);
            this.tabMuon.Controls.Add(this.dtNgayMuon);
            this.tabMuon.Controls.Add(this.label2);
            this.tabMuon.Controls.Add(this.cboNhanVienMuon);
            this.tabMuon.Controls.Add(this.label1);
            this.tabMuon.Controls.Add(this.lblTrangThai);
            this.tabMuon.Controls.Add(this.btnKiemTra);
            this.tabMuon.Controls.Add(this.cboDocGia);
            this.tabMuon.Controls.Add(this.labelDocGia);
            this.tabMuon.Location = new System.Drawing.Point(4, 30);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1174, 661);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(920, 595);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(180, 35);
            this.btnLapPhieu.TabIndex = 16;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Location = new System.Drawing.Point(620, 240);
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersWidth = 51;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(520, 330);
            this.dgvSachChon.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(616, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sách đã chọn (tối đa 3):";
            // 
            // btnBoSach
            // 
            this.btnBoSach.Location = new System.Drawing.Point(525, 370);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(80, 35);
            this.btnBoSach.TabIndex = 13;
            this.btnBoSach.Text = "<< Bỏ";
            this.btnBoSach.UseVisualStyleBackColor = true;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(525, 315);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(80, 35);
            this.btnThemSach.TabIndex = 12;
            this.btnThemSach.Text = "Thêm >>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            // 
            // dgvSachCon
            // 
            this.dgvSachCon.AllowUserToAddRows = false;
            this.dgvSachCon.AllowUserToDeleteRows = false;
            this.dgvSachCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachCon.Location = new System.Drawing.Point(30, 240);
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.RowHeadersWidth = 51;
            this.dgvSachCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachCon.Size = new System.Drawing.Size(480, 330);
            this.dgvSachCon.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sách còn trong kho:";
            // 
            // dtHenTra
            // 
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHenTra.Location = new System.Drawing.Point(740, 140);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(150, 29);
            this.dtHenTra.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hẹn trả:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(460, 140);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(150, 29);
            this.dtNgayMuon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày mượn:";
            // 
            // cboNhanVienMuon
            // 
            this.cboNhanVienMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(140, 140);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(190, 29);
            this.cboNhanVienMuon.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân viên lập:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.lblTrangThai.Location = new System.Drawing.Point(530, 80);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(217, 21);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái kiểm tra điều kiện...";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(360, 75);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(150, 32);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra điều kiện";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(100, 75);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(240, 29);
            this.cboDocGia.TabIndex = 1;
            // 
            // labelDocGia
            // 
            this.labelDocGia.AutoSize = true;
            this.labelDocGia.Location = new System.Drawing.Point(26, 80);
            this.labelDocGia.Name = "labelDocGia";
            this.labelDocGia.Size = new System.Drawing.Size(66, 21);
            this.labelDocGia.TabIndex = 0;
            this.labelDocGia.Text = "Độc giả:";
            // 
            // tabTra
            // 
            this.tabTra.Controls.Add(this.btnTraSach);
            this.tabTra.Controls.Add(this.numPhiPhat);
            this.tabTra.Controls.Add(this.label10);
            this.tabTra.Controls.Add(this.cboTinhTrang);
            this.tabTra.Controls.Add(this.label9);
            this.tabTra.Controls.Add(this.dtNgayTra);
            this.tabTra.Controls.Add(this.label8);
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.cboNhanVienTra);
            this.tabTra.Controls.Add(this.label7);
            this.tabTra.Controls.Add(this.btnTaiSachMuon);
            this.tabTra.Controls.Add(this.cboDocGiaTra);
            this.tabTra.Controls.Add(this.label6);
            this.tabTra.Location = new System.Drawing.Point(4, 30);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1174, 661);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách";
            this.tabTra.UseVisualStyleBackColor = true;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(920, 595);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(180, 35);
            this.btnTraSach.TabIndex = 12;
            this.btnTraSach.Text = "Xác nhận trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            // 
            // numPhiPhat
            // 
            this.numPhiPhat.Location = new System.Drawing.Point(630, 550);
            this.numPhiPhat.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(200, 29);
            this.numPhiPhat.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Phí phạt:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Bình thường",
            "Rách-Hư hỏng",
            "Mất"});
            this.cboTinhTrang.Location = new System.Drawing.Point(320, 550);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(180, 29);
            this.cboTinhTrang.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tình trạng:";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(100, 550);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(100, 29);
            this.dtNgayTra.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày trả:";
            // 
            // dgvDangMuon
            // 
            this.dgvDangMuon.AllowUserToAddRows = false;
            this.dgvDangMuon.AllowUserToDeleteRows = false;
            this.dgvDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangMuon.Location = new System.Drawing.Point(30, 140);
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.RowHeadersWidth = 51;
            this.dgvDangMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangMuon.Size = new System.Drawing.Size(1110, 380);
            this.dgvDangMuon.TabIndex = 5;
            // 
            // cboNhanVienTra
            // 
            this.cboNhanVienTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(740, 75);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(200, 29);
            this.cboNhanVienTra.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhân viên nhận:";
            // 
            // btnTaiSachMuon
            // 
            this.btnTaiSachMuon.Location = new System.Drawing.Point(430, 73);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(150, 32);
            this.btnTaiSachMuon.TabIndex = 2;
            this.btnTaiSachMuon.Text = "Tải sách đang mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            // 
            // cboDocGiaTra
            // 
            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(100, 75);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(300, 29);
            this.cboDocGiaTra.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Độc giả:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1100, 720);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 765);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.FrmMuonTra_Load);
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            this.btnBoSach.Click += new System.EventHandler(this.btnBoSach_Click);
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            this.btnTaiSachMuon.Click += new System.EventHandler(this.btnTaiSachMuon_Click);
            this.cboDocGiaTra.SelectedIndexChanged += new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.tabs.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            this.tabTra.ResumeLayout(false);
            this.tabTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHenTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label labelDocGia;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.NumericUpDown numPhiPhat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.ComboBox cboNhanVienTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTaiSachMuon;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
    }
}