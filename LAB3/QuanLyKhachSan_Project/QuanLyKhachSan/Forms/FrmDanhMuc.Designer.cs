namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabKhu, tabNV, tabLoaiTN, tabDV, tabQD;

        // Khu vực
        private System.Windows.Forms.TextBox txtKhuMa, txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.DataGridView dgvKhu;

        // Nhân viên
        private System.Windows.Forms.TextBox txtNVMa, txtNVTen, txtNVVaiTro, txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNV;

        // Loại tiện nghi
        private System.Windows.Forms.TextBox txtLoaiMa, txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.DataGridView dgvLoaiTN;

        // Dịch vụ
        private System.Windows.Forms.TextBox txtDVMa, txtDVTen, txtDVDVT;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDV;

        // Quy định đền bù
        private System.Windows.Forms.TextBox txtQDMa, txtQDMucDo;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.DataGridView dgvQD;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabKhu = new System.Windows.Forms.TabPage();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.tabQD = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();

            // ===== Tab Khu vực =====
            this.txtKhuMa = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(120, 23) };
            var lblKhuMa = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(120, 18), Text = "Mã khu vực" };
            this.txtKhuTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(160, 25), Size = new System.Drawing.Size(220, 23) };
            var lblKhuTen = new System.Windows.Forms.Label { Location = new System.Drawing.Point(160, 5), Size = new System.Drawing.Size(220, 18), Text = "Tên khu vực" };
            this.btnThemKhu = new System.Windows.Forms.Button { Location = new System.Drawing.Point(400, 23), Size = new System.Drawing.Size(90, 27), Text = "Thêm" };
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            this.dgvKhu = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabKhu.Controls.Add(lblKhuMa);
            this.tabKhu.Controls.Add(this.txtKhuMa);
            this.tabKhu.Controls.Add(lblKhuTen);
            this.tabKhu.Controls.Add(this.txtKhuTen);
            this.tabKhu.Controls.Add(this.btnThemKhu);
            this.tabKhu.Controls.Add(this.dgvKhu);
            this.tabKhu.Text = "Khu vực";

            // ===== Tab Nhân viên =====
            this.txtNVMa = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(90, 23) };
            var lblNVMa = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(90, 18), Text = "Mã NV" };
            this.txtNVTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(120, 25), Size = new System.Drawing.Size(160, 23) };
            var lblNVTen = new System.Windows.Forms.Label { Location = new System.Drawing.Point(120, 5), Size = new System.Drawing.Size(160, 18), Text = "Họ tên" };
            this.txtNVVaiTro = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(290, 25), Size = new System.Drawing.Size(140, 23) };
            var lblNVVaiTro = new System.Windows.Forms.Label { Location = new System.Drawing.Point(290, 5), Size = new System.Drawing.Size(140, 18), Text = "Vai trò" };
            this.txtNVSDT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(440, 25), Size = new System.Drawing.Size(110, 23) };
            var lblNVSDT = new System.Windows.Forms.Label { Location = new System.Drawing.Point(440, 5), Size = new System.Drawing.Size(110, 18), Text = "Số điện thoại" };
            this.btnThemNV = new System.Windows.Forms.Button { Location = new System.Drawing.Point(560, 23), Size = new System.Drawing.Size(60, 27), Text = "Thêm" };
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            this.dgvNV = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabNV.Controls.Add(lblNVMa);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(lblNVTen);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(lblNVVaiTro);
            this.tabNV.Controls.Add(this.txtNVVaiTro);
            this.tabNV.Controls.Add(lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.btnThemNV);
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Text = "Nhân viên";

            // ===== Tab Loại tiện nghi =====
            this.txtLoaiMa = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(120, 23) };
            var lblLoaiMa = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(120, 18), Text = "Mã loại TN" };
            this.txtLoaiTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(160, 25), Size = new System.Drawing.Size(220, 23) };
            var lblLoaiTen = new System.Windows.Forms.Label { Location = new System.Drawing.Point(160, 5), Size = new System.Drawing.Size(220, 18), Text = "Tên loại TN" };
            this.btnThemLoaiTN = new System.Windows.Forms.Button { Location = new System.Drawing.Point(400, 23), Size = new System.Drawing.Size(90, 27), Text = "Thêm" };
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabLoaiTN.Controls.Add(lblLoaiMa);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(lblLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Text = "Loại tiện nghi";

            // ===== Tab Dịch vụ =====
            this.txtDVMa = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(80, 23) };
            var lblDVMa = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(80, 18), Text = "Mã DV" };
            this.txtDVTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 25), Size = new System.Drawing.Size(180, 23) };
            var lblDVTen = new System.Windows.Forms.Label { Location = new System.Drawing.Point(110, 5), Size = new System.Drawing.Size(180, 18), Text = "Tên dịch vụ" };
            this.txtDVDVT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(300, 25), Size = new System.Drawing.Size(100, 23) };
            var lblDVDVT = new System.Windows.Forms.Label { Location = new System.Drawing.Point(300, 5), Size = new System.Drawing.Size(100, 18), Text = "Đơn vị tính" };
            this.numDVGia = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(410, 25), Size = new System.Drawing.Size(120, 23), Maximum = 100000000, DecimalPlaces = 0 };
            var lblDVGia = new System.Windows.Forms.Label { Location = new System.Drawing.Point(410, 5), Size = new System.Drawing.Size(120, 18), Text = "Đơn giá" };
            this.btnThemDV = new System.Windows.Forms.Button { Location = new System.Drawing.Point(540, 23), Size = new System.Drawing.Size(80, 27), Text = "Thêm" };
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            this.dgvDV = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabDV.Controls.Add(lblDVMa);
            this.tabDV.Controls.Add(this.txtDVMa);
            this.tabDV.Controls.Add(lblDVTen);
            this.tabDV.Controls.Add(this.txtDVTen);
            this.tabDV.Controls.Add(lblDVDVT);
            this.tabDV.Controls.Add(this.txtDVDVT);
            this.tabDV.Controls.Add(lblDVGia);
            this.tabDV.Controls.Add(this.numDVGia);
            this.tabDV.Controls.Add(this.btnThemDV);
            this.tabDV.Controls.Add(this.dgvDV);
            this.tabDV.Text = "Dịch vụ";

            // ===== Tab Quy định đền bù =====
            this.txtQDMa = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(90, 23) };
            var lblQDMa = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(90, 18), Text = "Mã quy định" };
            this.cboQDLoai = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(120, 25), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblQDLoai = new System.Windows.Forms.Label { Location = new System.Drawing.Point(120, 5), Size = new System.Drawing.Size(150, 18), Text = "Loại tiện nghi" };
            this.txtQDMucDo = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(280, 25), Size = new System.Drawing.Size(150, 23) };
            var lblQDMucDo = new System.Windows.Forms.Label { Location = new System.Drawing.Point(280, 5), Size = new System.Drawing.Size(150, 18), Text = "Mức độ thiệt hại" };
            this.numQDTien = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(440, 25), Size = new System.Drawing.Size(120, 23), Maximum = 100000000, DecimalPlaces = 0 };
            var lblQDTien = new System.Windows.Forms.Label { Location = new System.Drawing.Point(440, 5), Size = new System.Drawing.Size(120, 18), Text = "Mức đền bù" };
            this.btnThemQD = new System.Windows.Forms.Button { Location = new System.Drawing.Point(570, 23), Size = new System.Drawing.Size(50, 27), Text = "Thêm" };
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            this.dgvQD = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabQD.Controls.Add(lblQDMa);
            this.tabQD.Controls.Add(this.txtQDMa);
            this.tabQD.Controls.Add(lblQDLoai);
            this.tabQD.Controls.Add(this.cboQDLoai);
            this.tabQD.Controls.Add(lblQDMucDo);
            this.tabQD.Controls.Add(this.txtQDMucDo);
            this.tabQD.Controls.Add(lblQDTien);
            this.tabQD.Controls.Add(this.numQDTien);
            this.tabQD.Controls.Add(this.btnThemQD);
            this.tabQD.Controls.Add(this.dgvQD);
            this.tabQD.Text = "Quy định đền bù";

            // ===== TabControl tổng =====
            this.tabDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.tabDanhMuc.Size = new System.Drawing.Size(660, 420);
            this.tabDanhMuc.Controls.Add(this.tabKhu);
            this.tabDanhMuc.Controls.Add(this.tabNV);
            this.tabDanhMuc.Controls.Add(this.tabLoaiTN);
            this.tabDanhMuc.Controls.Add(this.tabDV);
            this.tabDanhMuc.Controls.Add(this.tabQD);

            this.btnDong.Location = new System.Drawing.Point(590, 440);
            this.btnDong.Size = new System.Drawing.Size(82, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // ===== Form =====
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.tabDanhMuc);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục khách sạn";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
        }
    }
}
