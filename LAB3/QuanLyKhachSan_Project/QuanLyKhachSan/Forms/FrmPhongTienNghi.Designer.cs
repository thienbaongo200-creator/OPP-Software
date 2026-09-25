namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabChinh;
        private System.Windows.Forms.TabPage tabPhong, tabTN, tabLD;

        // Tab Phòng
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.NumericUpDown numMax, numGia;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;

        // Tab Tiện nghi
        private System.Windows.Forms.TextBox txtMaTN, txtTinhTrang;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.DataGridView dgvTN;

        // Tab Lắp đặt
        private System.Windows.Forms.TextBox txtSoLD, txtTTLD, txtGhiChu;
        private System.Windows.Forms.ComboBox cboTN, cboPhong, cboNV;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.DataGridView dgvLD;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabChinh = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.tabLD = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();

            // ===== Tab Phòng =====
            var lblPhong = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(100, 18), Text = "Số phòng" };
            this.txtPhong = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(100, 23) };
            var lblKhu = new System.Windows.Forms.Label { Location = new System.Drawing.Point(130, 5), Size = new System.Drawing.Size(120, 18), Text = "Khu vực" };
            this.cboKhu = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(130, 25), Size = new System.Drawing.Size(120, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblMax = new System.Windows.Forms.Label { Location = new System.Drawing.Point(260, 5), Size = new System.Drawing.Size(110, 18), Text = "Số người tối đa" };
            this.numMax = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(260, 25), Size = new System.Drawing.Size(100, 23), Minimum = 1, Maximum = 20 };
            var lblGia = new System.Windows.Forms.Label { Location = new System.Drawing.Point(370, 5), Size = new System.Drawing.Size(110, 18), Text = "Đơn giá / ngày" };
            this.numGia = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(370, 25), Size = new System.Drawing.Size(120, 23), Maximum = 100000000 };
            this.btnThemPhong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(500, 23), Size = new System.Drawing.Size(100, 27), Text = "Thêm phòng" };
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            this.dgvPhong = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabPhong.Controls.Add(lblPhong); this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(lblKhu); this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(lblMax); this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(lblGia); this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Text = "Phòng";

            // ===== Tab Tiện nghi =====
            var lblMaTN = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(100, 18), Text = "Mã tiện nghi" };
            this.txtMaTN = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(100, 23) };
            var lblLoaiTN = new System.Windows.Forms.Label { Location = new System.Drawing.Point(130, 5), Size = new System.Drawing.Size(120, 18), Text = "Loại tiện nghi" };
            this.cboLoai = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(130, 25), Size = new System.Drawing.Size(120, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblSTT = new System.Windows.Forms.Label { Location = new System.Drawing.Point(260, 5), Size = new System.Drawing.Size(90, 18), Text = "Số thứ tự" };
            this.numSTT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(260, 25), Size = new System.Drawing.Size(80, 23), Minimum = 1, Maximum = 999 };
            var lblTT = new System.Windows.Forms.Label { Location = new System.Drawing.Point(350, 5), Size = new System.Drawing.Size(150, 18), Text = "Tình trạng" };
            this.txtTinhTrang = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(350, 25), Size = new System.Drawing.Size(150, 23) };
            this.btnThemTN = new System.Windows.Forms.Button { Location = new System.Drawing.Point(510, 23), Size = new System.Drawing.Size(90, 27), Text = "Thêm TN" };
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            this.dgvTN = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabTN.Controls.Add(lblMaTN); this.tabTN.Controls.Add(this.txtMaTN);
            this.tabTN.Controls.Add(lblLoaiTN); this.tabTN.Controls.Add(this.cboLoai);
            this.tabTN.Controls.Add(lblSTT); this.tabTN.Controls.Add(this.numSTT);
            this.tabTN.Controls.Add(lblTT); this.tabTN.Controls.Add(this.txtTinhTrang);
            this.tabTN.Controls.Add(this.btnThemTN);
            this.tabTN.Controls.Add(this.dgvTN);
            this.tabTN.Text = "Tiện nghi";

            // ===== Tab Lắp đặt / luân chuyển =====
            var lblSoLD = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(100, 18), Text = "Số phiếu lắp đặt" };
            this.txtSoLD = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(100, 23) };
            var lblTN2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(130, 5), Size = new System.Drawing.Size(90, 18), Text = "Tiện nghi" };
            this.cboTN = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(130, 25), Size = new System.Drawing.Size(90, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblPhong2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(230, 5), Size = new System.Drawing.Size(90, 18), Text = "Phòng" };
            this.cboPhong = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(230, 25), Size = new System.Drawing.Size(90, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblNgay = new System.Windows.Forms.Label { Location = new System.Drawing.Point(330, 5), Size = new System.Drawing.Size(90, 18), Text = "Ngày lắp" };
            this.dtNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(330, 25), Size = new System.Drawing.Size(120, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };
            var lblTTLD = new System.Windows.Forms.Label { Location = new System.Drawing.Point(460, 5), Size = new System.Drawing.Size(90, 18), Text = "Tình trạng" };
            this.txtTTLD = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(460, 25), Size = new System.Drawing.Size(90, 23) };
            var lblNV = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 55), Size = new System.Drawing.Size(150, 18), Text = "Nhân viên phụ trách" };
            this.cboNV = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(20, 75), Size = new System.Drawing.Size(200, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var lblGhiChu = new System.Windows.Forms.Label { Location = new System.Drawing.Point(230, 55), Size = new System.Drawing.Size(200, 18), Text = "Ghi chú" };
            this.txtGhiChu = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(230, 75), Size = new System.Drawing.Size(260, 23) };
            this.btnLapDat = new System.Windows.Forms.Button { Location = new System.Drawing.Point(500, 73), Size = new System.Drawing.Size(100, 27), Text = "Lập phiếu" };
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            this.dgvLD = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 110), Size = new System.Drawing.Size(600, 255), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.tabLD.Controls.Add(lblSoLD); this.tabLD.Controls.Add(this.txtSoLD);
            this.tabLD.Controls.Add(lblTN2); this.tabLD.Controls.Add(this.cboTN);
            this.tabLD.Controls.Add(lblPhong2); this.tabLD.Controls.Add(this.cboPhong);
            this.tabLD.Controls.Add(lblNgay); this.tabLD.Controls.Add(this.dtNgay);
            this.tabLD.Controls.Add(lblTTLD); this.tabLD.Controls.Add(this.txtTTLD);
            this.tabLD.Controls.Add(lblNV); this.tabLD.Controls.Add(this.cboNV);
            this.tabLD.Controls.Add(lblGhiChu); this.tabLD.Controls.Add(this.txtGhiChu);
            this.tabLD.Controls.Add(this.btnLapDat);
            this.tabLD.Controls.Add(this.dgvLD);
            this.tabLD.Text = "Lắp đặt / luân chuyển";

            this.tabChinh.Location = new System.Drawing.Point(12, 12);
            this.tabChinh.Size = new System.Drawing.Size(660, 420);
            this.tabChinh.Controls.Add(this.tabPhong);
            this.tabChinh.Controls.Add(this.tabTN);
            this.tabChinh.Controls.Add(this.tabLD);

            this.btnDong.Location = new System.Drawing.Point(590, 440);
            this.btnDong.Size = new System.Drawing.Size(82, 30);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.tabChinh);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.Frm_Load);
        }
    }
}
