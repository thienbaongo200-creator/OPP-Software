namespace QuanLyThuVien.Forms
{
    partial class FrmDanhMuc
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
            this.tabNV = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnNVMoi = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVCapNhat = new System.Windows.Forms.Button();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNVPhai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNVHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabTL = new System.Windows.Forms.TabPage();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.btnTLMoi = new System.Windows.Forms.Button();
            this.btnTLXoa = new System.Windows.Forms.Button();
            this.btnTLCapNhat = new System.Windows.Forms.Button();
            this.btnTLThem = new System.Windows.Forms.Button();
            this.txtTLTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTLMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.btnNXBMoi = new System.Windows.Forms.Button();
            this.btnNXBXoa = new System.Windows.Forms.Button();
            this.btnNXBCapNhat = new System.Windows.Forms.Button();
            this.btnNXBThem = new System.Windows.Forms.Button();
            this.txtNXBSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNXBDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNXBMa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabNV);
            this.tabs.Controls.Add(this.tabTL);
            this.tabs.Controls.Add(this.tabNXB);
            this.tabs.Location = new System.Drawing.Point(24, 60);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(950, 580);
            this.tabs.TabIndex = 0;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Controls.Add(this.btnNVMoi);
            this.tabNV.Controls.Add(this.btnNVXoa);
            this.tabNV.Controls.Add(this.btnNVCapNhat);
            this.tabNV.Controls.Add(this.btnNVThem);
            this.tabNV.Controls.Add(this.txtNVChucVu);
            this.tabNV.Controls.Add(this.label6);
            this.tabNV.Controls.Add(this.dtNVNgaySinh);
            this.tabNV.Controls.Add(this.label5);
            this.tabNV.Controls.Add(this.cboNVPhai);
            this.tabNV.Controls.Add(this.label4);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.label3);
            this.tabNV.Controls.Add(this.txtNVHo);
            this.tabNV.Controls.Add(this.label2);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.label1);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.label7);
            this.tabNV.Location = new System.Drawing.Point(4, 28);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(942, 548);
            this.tabNV.TabIndex = 0;
            this.tabNV.Text = "[Nhân viên]";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(20, 180);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(900, 345);
            this.dgvNV.TabIndex = 16;
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // btnNVMoi
            // 
            this.btnNVMoi.Location = new System.Drawing.Point(805, 115);
            this.btnNVMoi.Name = "btnNVMoi";
            this.btnNVMoi.Size = new System.Drawing.Size(90, 30);
            this.btnNVMoi.TabIndex = 15;
            this.btnNVMoi.Text = "Làm mới";
            this.btnNVMoi.UseVisualStyleBackColor = true;
            this.btnNVMoi.Click += new System.EventHandler(this.btnNVMoi_Click);
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.Location = new System.Drawing.Point(700, 115);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(90, 30);
            this.btnNVXoa.TabIndex = 14;
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.UseVisualStyleBackColor = true;
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVCapNhat
            // 
            this.btnNVCapNhat.Location = new System.Drawing.Point(805, 70);
            this.btnNVCapNhat.Name = "btnNVCapNhat";
            this.btnNVCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnNVCapNhat.TabIndex = 13;
            this.btnNVCapNhat.Text = "Cập nhật";
            this.btnNVCapNhat.UseVisualStyleBackColor = true;
            this.btnNVCapNhat.Click += new System.EventHandler(this.btnNVCapNhat_Click);
            // 
            // btnNVThem
            // 
            this.btnNVThem.Location = new System.Drawing.Point(700, 70);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(90, 30);
            this.btnNVThem.TabIndex = 12;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = true;
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // txtNVChucVu
            // 
            this.txtNVChucVu.Location = new System.Drawing.Point(490, 115);
            this.txtNVChucVu.Name = "txtNVChucVu";
            this.txtNVChucVu.Size = new System.Drawing.Size(160, 26);
            this.txtNVChucVu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chức vụ:";
            // 
            // dtNVNgaySinh
            // 
            this.dtNVNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Location = new System.Drawing.Point(490, 72);
            this.dtNVNgaySinh.Name = "dtNVNgaySinh";
            this.dtNVNgaySinh.Size = new System.Drawing.Size(160, 26);
            this.dtNVNgaySinh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh:";
            // 
            // cboNVPhai
            // 
            this.cboNVPhai.FormattingEnabled = true;
            this.cboNVPhai.Location = new System.Drawing.Point(490, 30);
            this.cboNVPhai.Name = "cboNVPhai";
            this.cboNVPhai.Size = new System.Drawing.Size(160, 27);
            this.cboNVPhai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phái:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(135, 115);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(190, 26);
            this.txtNVTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txtNVHo
            // 
            this.txtNVHo.Location = new System.Drawing.Point(135, 72);
            this.txtNVHo.Name = "txtNVHo";
            this.txtNVHo.Size = new System.Drawing.Size(190, 26);
            this.txtNVHo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(135, 30);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(190, 26);
            this.txtNVMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(700, 30);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(100, 26);
            this.txtNVSDT.TabIndex = 17;
            this.txtNVSDT.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "ĐT:";
            this.label7.Visible = false;
            // 
            // tabTL
            // 
            this.tabTL.Controls.Add(this.dgvTL);
            this.tabTL.Controls.Add(this.btnTLMoi);
            this.tabTL.Controls.Add(this.btnTLXoa);
            this.tabTL.Controls.Add(this.btnTLCapNhat);
            this.tabTL.Controls.Add(this.btnTLThem);
            this.tabTL.Controls.Add(this.txtTLTen);
            this.tabTL.Controls.Add(this.label9);
            this.tabTL.Controls.Add(this.txtTLMa);
            this.tabTL.Controls.Add(this.label8);
            this.tabTL.Location = new System.Drawing.Point(4, 28);
            this.tabTL.Name = "tabTL";
            this.tabTL.Padding = new System.Windows.Forms.Padding(3);
            this.tabTL.Size = new System.Drawing.Size(942, 548);
            this.tabTL.TabIndex = 1;
            this.tabTL.Text = "[Thể loại]";
            this.tabTL.UseVisualStyleBackColor = true;
            // 
            // dgvTL
            // 
            this.dgvTL.AllowUserToAddRows = false;
            this.dgvTL.AllowUserToDeleteRows = false;
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Location = new System.Drawing.Point(20, 150);
            this.dgvTL.MultiSelect = false;
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.ReadOnly = true;
            this.dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTL.Size = new System.Drawing.Size(900, 375);
            this.dgvTL.TabIndex = 8;
            this.dgvTL.SelectionChanged += new System.EventHandler(this.dgvTL_SelectionChanged);
            // 
            // btnTLMoi
            // 
            this.btnTLMoi.Location = new System.Drawing.Point(530, 90);
            this.btnTLMoi.Name = "btnTLMoi";
            this.btnTLMoi.Size = new System.Drawing.Size(90, 30);
            this.btnTLMoi.TabIndex = 7;
            this.btnTLMoi.Text = "Làm mới";
            this.btnTLMoi.UseVisualStyleBackColor = true;
            this.btnTLMoi.Click += new System.EventHandler(this.btnTLMoi_Click);
            // 
            // btnTLXoa
            // 
            this.btnTLXoa.Location = new System.Drawing.Point(420, 90);
            this.btnTLXoa.Name = "btnTLXoa";
            this.btnTLXoa.Size = new System.Drawing.Size(90, 30);
            this.btnTLXoa.TabIndex = 6;
            this.btnTLXoa.Text = "Xóa";
            this.btnTLXoa.UseVisualStyleBackColor = true;
            this.btnTLXoa.Click += new System.EventHandler(this.btnTLXoa_Click);
            // 
            // btnTLCapNhat
            // 
            this.btnTLCapNhat.Location = new System.Drawing.Point(310, 90);
            this.btnTLCapNhat.Name = "btnTLCapNhat";
            this.btnTLCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnTLCapNhat.TabIndex = 5;
            this.btnTLCapNhat.Text = "Cập nhật";
            this.btnTLCapNhat.UseVisualStyleBackColor = true;
            this.btnTLCapNhat.Click += new System.EventHandler(this.btnTLCapNhat_Click);
            // 
            // btnTLThem
            // 
            this.btnTLThem.Location = new System.Drawing.Point(200, 90);
            this.btnTLThem.Name = "btnTLThem";
            this.btnTLThem.Size = new System.Drawing.Size(90, 30);
            this.btnTLThem.TabIndex = 4;
            this.btnTLThem.Text = "Thêm";
            this.btnTLThem.UseVisualStyleBackColor = true;
            this.btnTLThem.Click += new System.EventHandler(this.btnTLThem_Click);
            // 
            // txtTLTen
            // 
            this.txtTLTen.Location = new System.Drawing.Point(540, 30);
            this.txtTLTen.Name = "txtTLTen";
            this.txtTLTen.Size = new System.Drawing.Size(250, 26);
            this.txtTLTen.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên thể loại:";
            // 
            // txtTLMa
            // 
            this.txtTLMa.Location = new System.Drawing.Point(200, 30);
            this.txtTLMa.Name = "txtTLMa";
            this.txtTLMa.Size = new System.Drawing.Size(200, 26);
            this.txtTLMa.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã thể loại:";
            // 
            // tabNXB
            // 
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Controls.Add(this.btnNXBMoi);
            this.tabNXB.Controls.Add(this.btnNXBXoa);
            this.tabNXB.Controls.Add(this.btnNXBCapNhat);
            this.tabNXB.Controls.Add(this.btnNXBThem);
            this.tabNXB.Controls.Add(this.txtNXBSDT);
            this.tabNXB.Controls.Add(this.label12);
            this.tabNXB.Controls.Add(this.txtNXBDiaChi);
            this.tabNXB.Controls.Add(this.label11);
            this.tabNXB.Controls.Add(this.txtNXBMa);
            this.tabNXB.Controls.Add(this.label10);
            this.tabNXB.Location = new System.Drawing.Point(4, 28);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Padding = new System.Windows.Forms.Padding(3);
            this.tabNXB.Size = new System.Drawing.Size(942, 548);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "[Nhà xuất bản]";
            this.tabNXB.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(20, 180);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(900, 345);
            this.dgvNXB.TabIndex = 10;
            this.dgvNXB.SelectionChanged += new System.EventHandler(this.dgvNXB_SelectionChanged);
            // 
            // btnNXBMoi
            // 
            this.btnNXBMoi.Location = new System.Drawing.Point(530, 120);
            this.btnNXBMoi.Name = "btnNXBMoi";
            this.btnNXBMoi.Size = new System.Drawing.Size(90, 30);
            this.btnNXBMoi.TabIndex = 9;
            this.btnNXBMoi.Text = "Làm mới";
            this.btnNXBMoi.UseVisualStyleBackColor = true;
            this.btnNXBMoi.Click += new System.EventHandler(this.btnNXBMoi_Click);
            // 
            // btnNXBXoa
            // 
            this.btnNXBXoa.Location = new System.Drawing.Point(420, 120);
            this.btnNXBXoa.Name = "btnNXBXoa";
            this.btnNXBXoa.Size = new System.Drawing.Size(90, 30);
            this.btnNXBXoa.TabIndex = 8;
            this.btnNXBXoa.Text = "Xóa";
            this.btnNXBXoa.UseVisualStyleBackColor = true;
            this.btnNXBXoa.Click += new System.EventHandler(this.btnNXBXoa_Click);
            // 
            // btnNXBCapNhat
            // 
            this.btnNXBCapNhat.Location = new System.Drawing.Point(310, 120);
            this.btnNXBCapNhat.Name = "btnNXBCapNhat";
            this.btnNXBCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnNXBCapNhat.TabIndex = 7;
            this.btnNXBCapNhat.Text = "Cập nhật";
            this.btnNXBCapNhat.UseVisualStyleBackColor = true;
            this.btnNXBCapNhat.Click += new System.EventHandler(this.btnNXBCapNhat_Click);
            // 
            // btnNXBThem
            // 
            this.btnNXBThem.Location = new System.Drawing.Point(200, 120);
            this.btnNXBThem.Name = "btnNXBThem";
            this.btnNXBThem.Size = new System.Drawing.Size(90, 30);
            this.btnNXBThem.TabIndex = 6;
            this.btnNXBThem.Text = "Thêm";
            this.btnNXBThem.UseVisualStyleBackColor = true;
            this.btnNXBThem.Click += new System.EventHandler(this.btnNXBThem_Click);
            // 
            // txtNXBSDT
            // 
            this.txtNXBSDT.Location = new System.Drawing.Point(200, 75);
            this.txtNXBSDT.Name = "txtNXBSDT";
            this.txtNXBSDT.Size = new System.Drawing.Size(200, 26);
            this.txtNXBSDT.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Điện thoại:";
            // 
            // txtNXBDiaChi
            // 
            this.txtNXBDiaChi.Location = new System.Drawing.Point(540, 30);
            this.txtNXBDiaChi.Name = "txtNXBDiaChi";
            this.txtNXBDiaChi.Size = new System.Drawing.Size(300, 26);
            this.txtNXBDiaChi.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Địa chỉ:";
            // 
            // txtNXBMa
            // 
            this.txtNXBMa.Location = new System.Drawing.Point(200, 30);
            this.txtNXBMa.Name = "txtNXBMa";
            this.txtNXBMa.Size = new System.Drawing.Size(200, 26);
            this.txtNXBMa.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã NXB:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTitle.Location = new System.Drawing.Point(24, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Danh mục và nhân viên";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(880, 650);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Visible = false;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục và nhân viên";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabs.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabTL.ResumeLayout(false);
            this.tabTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.tabNXB.ResumeLayout(false);
            this.tabNXB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabTL;
        private System.Windows.Forms.TabPage tabNXB;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNVHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNVPhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.Button btnNVCapNhat;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVMoi;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtTLMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTLTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTLThem;
        private System.Windows.Forms.Button btnTLCapNhat;
        private System.Windows.Forms.Button btnTLXoa;
        private System.Windows.Forms.Button btnTLMoi;
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.TextBox txtNXBMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNXBDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNXBSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNXBThem;
        private System.Windows.Forms.Button btnNXBCapNhat;
        private System.Windows.Forms.Button btnNXBXoa;
        private System.Windows.Forms.Button btnNXBMoi;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Button btnDong;
    }
}