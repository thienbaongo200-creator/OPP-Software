namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabChinh;
        private System.Windows.Forms.TabPage tabKhach, tabDat, tabNhan;

        // Tab Khách hàng
        private System.Windows.Forms.TextBox txtMaKH, txtTenKH, txtCMND, txtQT, txtSDT;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridView dgvKhach;

        // Tab Đặt phòng
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach, cboNV, cboKenh;
        private System.Windows.Forms.DateTimePicker dtLap, dtNhan, dtTra;
        private System.Windows.Forms.NumericUpDown numCoc, numSoNguoi;
        private System.Windows.Forms.DataGridView dgvPhong, dgvChon;
        private System.Windows.Forms.Button btnThemPhong, btnBoPhong, btnLapPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;

        // Tab Nhận phòng / người lưu trú
        private System.Windows.Forms.TextBox txtPhieuChon, txtNguoiPhong, txtNguoiTen, txtNguoiCMND, txtNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi, btnNhanPhong, btnNoShow;
        private System.Windows.Forms.DataGridView dgvCT, dgvNguoi;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabChinh = new System.Windows.Forms.TabControl();
            this.tabKhach = new System.Windows.Forms.TabPage();
            this.tabDat = new System.Windows.Forms.TabPage();
            this.tabNhan = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();

            // ===== Tab Khách hàng =====
            var l1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(80, 18), Text = "Mã khách" };
            this.txtMaKH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(80, 23) };
            var l2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(110, 5), Size = new System.Drawing.Size(150, 18), Text = "Họ tên" };
            this.txtTenKH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 25), Size = new System.Drawing.Size(150, 23) };
            var l3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(270, 5), Size = new System.Drawing.Size(110, 18), Text = "Số CMND" };
            this.txtCMND = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(270, 25), Size = new System.Drawing.Size(110, 23) };
            var l4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(390, 5), Size = new System.Drawing.Size(100, 18), Text = "Quốc tịch" };
            this.txtQT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(390, 25), Size = new System.Drawing.Size(100, 23) };
            var l5 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(500, 5), Size = new System.Drawing.Size(90, 18), Text = "Điện thoại" };
            this.txtSDT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(500, 25), Size = new System.Drawing.Size(90, 23) };
            this.btnThemKhach = new System.Windows.Forms.Button { Location = new System.Drawing.Point(600, 23), Size = new System.Drawing.Size(80, 27), Text = "Thêm" };
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            this.dgvKhach = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(660, 320), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabKhach.Controls.Add(l1); this.tabKhach.Controls.Add(this.txtMaKH);
            this.tabKhach.Controls.Add(l2); this.tabKhach.Controls.Add(this.txtTenKH);
            this.tabKhach.Controls.Add(l3); this.tabKhach.Controls.Add(this.txtCMND);
            this.tabKhach.Controls.Add(l4); this.tabKhach.Controls.Add(this.txtQT);
            this.tabKhach.Controls.Add(l5); this.tabKhach.Controls.Add(this.txtSDT);
            this.tabKhach.Controls.Add(this.btnThemKhach);
            this.tabKhach.Controls.Add(this.dgvKhach);
            this.tabKhach.Text = "Khách hàng";

            // ===== Tab Đặt phòng =====
            var d1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(90, 18), Text = "Số phiếu đặt" };
            this.txtSoPhieu = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(90, 23) };
            var d2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(120, 5), Size = new System.Drawing.Size(120, 18), Text = "Khách" };
            this.cboKhach = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(120, 25), Size = new System.Drawing.Size(120, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var d3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(250, 5), Size = new System.Drawing.Size(120, 18), Text = "Lễ tân" };
            this.cboNV = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(250, 25), Size = new System.Drawing.Size(120, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var d4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(380, 5), Size = new System.Drawing.Size(90, 18), Text = "Kênh đặt" };
            this.cboKenh = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(380, 25), Size = new System.Drawing.Size(90, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var d5 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(480, 5), Size = new System.Drawing.Size(90, 18), Text = "Tiền cọc" };
            this.numCoc = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(480, 25), Size = new System.Drawing.Size(100, 23), Maximum = 100000000 };

            var d6 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 52), Size = new System.Drawing.Size(90, 18), Text = "Ngày lập" };
            this.dtLap = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(20, 72), Size = new System.Drawing.Size(120, 23) };
            var d7 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(150, 52), Size = new System.Drawing.Size(90, 18), Text = "Ngày nhận" };
            this.dtNhan = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(150, 72), Size = new System.Drawing.Size(120, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };
            var d8 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(280, 52), Size = new System.Drawing.Size(100, 18), Text = "Ngày trả dự kiến" };
            this.dtTra = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(280, 72), Size = new System.Drawing.Size(120, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };

            var d9 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 105), Size = new System.Drawing.Size(180, 18), Text = "Danh sách phòng" };
            this.dgvPhong = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 125), Size = new System.Drawing.Size(300, 150), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            var d10 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(340, 105), Size = new System.Drawing.Size(90, 18), Text = "Số người" };
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(340, 125), Size = new System.Drawing.Size(70, 23), Minimum = 1, Maximum = 20 };
            this.btnThemPhong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(340, 155), Size = new System.Drawing.Size(90, 27), Text = "Thêm phòng" };
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            this.btnBoPhong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(340, 190), Size = new System.Drawing.Size(90, 27), Text = "Bỏ phòng" };
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            this.dgvChon = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(440, 125), Size = new System.Drawing.Size(240, 150), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.btnLapPhieu = new System.Windows.Forms.Button { Location = new System.Drawing.Point(580, 285), Size = new System.Drawing.Size(100, 30), Text = "Lập phiếu đặt" };
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);

            var d11 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 325), Size = new System.Drawing.Size(180, 18), Text = "Danh sách phiếu đặt phòng" };
            this.dgvPhieu = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 345), Size = new System.Drawing.Size(660, 100), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);

            this.tabDat.Controls.Add(d1); this.tabDat.Controls.Add(this.txtSoPhieu);
            this.tabDat.Controls.Add(d2); this.tabDat.Controls.Add(this.cboKhach);
            this.tabDat.Controls.Add(d3); this.tabDat.Controls.Add(this.cboNV);
            this.tabDat.Controls.Add(d4); this.tabDat.Controls.Add(this.cboKenh);
            this.tabDat.Controls.Add(d5); this.tabDat.Controls.Add(this.numCoc);
            this.tabDat.Controls.Add(d6); this.tabDat.Controls.Add(this.dtLap);
            this.tabDat.Controls.Add(d7); this.tabDat.Controls.Add(this.dtNhan);
            this.tabDat.Controls.Add(d8); this.tabDat.Controls.Add(this.dtTra);
            this.tabDat.Controls.Add(d9); this.tabDat.Controls.Add(this.dgvPhong);
            this.tabDat.Controls.Add(d10); this.tabDat.Controls.Add(this.numSoNguoi);
            this.tabDat.Controls.Add(this.btnThemPhong); this.tabDat.Controls.Add(this.btnBoPhong);
            this.tabDat.Controls.Add(this.dgvChon); this.tabDat.Controls.Add(this.btnLapPhieu);
            this.tabDat.Controls.Add(d11); this.tabDat.Controls.Add(this.dgvPhieu);
            this.tabDat.Text = "Đặt phòng";

            // ===== Tab Nhận phòng / người lưu trú =====
            var n1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(120, 18), Text = "Phiếu đang chọn" };
            this.txtPhieuChon = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(120, 23), ReadOnly = true };

            var n2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 55), Size = new System.Drawing.Size(160, 18), Text = "Chi tiết phòng đã đặt" };
            this.dgvCT = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 75), Size = new System.Drawing.Size(300, 130), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            var n3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(340, 55), Size = new System.Drawing.Size(160, 18), Text = "Người lưu trú" };
            this.dgvNguoi = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(340, 75), Size = new System.Drawing.Size(320, 130), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            var n4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 215), Size = new System.Drawing.Size(80, 18), Text = "Phòng" };
            this.txtNguoiPhong = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 235), Size = new System.Drawing.Size(80, 23) };
            var n5 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(110, 215), Size = new System.Drawing.Size(150, 18), Text = "Họ tên" };
            this.txtNguoiTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 235), Size = new System.Drawing.Size(150, 23) };
            var n6 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(270, 215), Size = new System.Drawing.Size(110, 18), Text = "Số CMND" };
            this.txtNguoiCMND = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(270, 235), Size = new System.Drawing.Size(110, 23) };
            var n7 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(390, 215), Size = new System.Drawing.Size(100, 18), Text = "Quốc tịch" };
            this.txtNguoiQT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(390, 235), Size = new System.Drawing.Size(100, 23) };
            this.btnThemNguoi = new System.Windows.Forms.Button { Location = new System.Drawing.Point(500, 233), Size = new System.Drawing.Size(150, 27), Text = "Thêm người lưu trú" };
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);

            this.btnNhanPhong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(20, 280), Size = new System.Drawing.Size(130, 32), Text = "Nhận phòng" };
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            this.btnNoShow = new System.Windows.Forms.Button { Location = new System.Drawing.Point(160, 280), Size = new System.Drawing.Size(130, 32), Text = "Đánh dấu No-show" };
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);

            this.tabNhan.Controls.Add(n1); this.tabNhan.Controls.Add(this.txtPhieuChon);
            this.tabNhan.Controls.Add(n2); this.tabNhan.Controls.Add(this.dgvCT);
            this.tabNhan.Controls.Add(n3); this.tabNhan.Controls.Add(this.dgvNguoi);
            this.tabNhan.Controls.Add(n4); this.tabNhan.Controls.Add(this.txtNguoiPhong);
            this.tabNhan.Controls.Add(n5); this.tabNhan.Controls.Add(this.txtNguoiTen);
            this.tabNhan.Controls.Add(n6); this.tabNhan.Controls.Add(this.txtNguoiCMND);
            this.tabNhan.Controls.Add(n7); this.tabNhan.Controls.Add(this.txtNguoiQT);
            this.tabNhan.Controls.Add(this.btnThemNguoi);
            this.tabNhan.Controls.Add(this.btnNhanPhong);
            this.tabNhan.Controls.Add(this.btnNoShow);
            this.tabNhan.Text = "Nhận phòng / Người lưu trú";

            this.tabChinh.Location = new System.Drawing.Point(12, 12);
            this.tabChinh.Size = new System.Drawing.Size(700, 480);
            this.tabChinh.Controls.Add(this.tabKhach);
            this.tabChinh.Controls.Add(this.tabDat);
            this.tabChinh.Controls.Add(this.tabNhan);

            this.btnDong.Location = new System.Drawing.Point(630, 500);
            this.btnDong.Size = new System.Drawing.Size(82, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(724, 544);
            this.Controls.Add(this.tabChinh);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.Frm_Load);
        }
    }
}
