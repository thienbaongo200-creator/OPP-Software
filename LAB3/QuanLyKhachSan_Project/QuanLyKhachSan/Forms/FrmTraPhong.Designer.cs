namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cboDat, cboNV, cboNV2, cboHT;
        private System.Windows.Forms.TextBox txtPhong, txtSoDB, txtMucDo, txtSoHD, txtHDChon, txtMaTT;
        private System.Windows.Forms.NumericUpDown numDenBu, numSoNgay, numTienTT;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvDBChon, dgvHD;
        private System.Windows.Forms.Button btnThemDB, btnLapDB, btnLapHD, btnThanhToan, btnTraPhong, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var l1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(130, 18), Text = "Phiếu đang ở" };
            this.cboDat = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };

            // Phòng + tiện nghi + đền bù chọn
            var l2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 55), Size = new System.Drawing.Size(120, 18), Text = "Phòng thuộc phiếu" };
            this.dgvPhong = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 75), Size = new System.Drawing.Size(180, 130), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);

            var l3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(215, 55), Size = new System.Drawing.Size(150, 18), Text = "Tiện nghi đã lắp" };
            this.dgvTN = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(215, 75), Size = new System.Drawing.Size(220, 130), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            var l4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(450, 55), Size = new System.Drawing.Size(200, 18), Text = "Tiện nghi đền bù (đã chọn)" };
            this.dgvDBChon = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(450, 75), Size = new System.Drawing.Size(280, 130), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.txtPhong = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 210), Size = new System.Drawing.Size(1, 1), Visible = false };

            var l5 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 215), Size = new System.Drawing.Size(90, 18), Text = "Số phiếu ĐB" };
            this.txtSoDB = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 235), Size = new System.Drawing.Size(90, 23) };
            var l6 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(120, 215), Size = new System.Drawing.Size(120, 18), Text = "Mức độ thiệt hại" };
            this.txtMucDo = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(120, 235), Size = new System.Drawing.Size(120, 23) };
            var l7 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(250, 215), Size = new System.Drawing.Size(90, 18), Text = "Số tiền" };
            this.numDenBu = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(250, 235), Size = new System.Drawing.Size(100, 23), Maximum = 100000000 };
            var lNVDB = new System.Windows.Forms.Label { Location = new System.Drawing.Point(360, 215), Size = new System.Drawing.Size(120, 18), Text = "NV lập phiếu ĐB" };
            this.cboNV = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(360, 235), Size = new System.Drawing.Size(120, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.btnThemDB = new System.Windows.Forms.Button { Location = new System.Drawing.Point(490, 233), Size = new System.Drawing.Size(110, 27), Text = "Thêm vào phiếu" };
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            this.btnLapDB = new System.Windows.Forms.Button { Location = new System.Drawing.Point(605, 233), Size = new System.Drawing.Size(125, 27), Text = "Lập phiếu đền bù" };
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            this.Controls.Add(lNVDB); this.Controls.Add(this.cboNV);

            var l8 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 270), Size = new System.Drawing.Size(90, 18), Text = "Số hóa đơn" };
            this.txtSoHD = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 290), Size = new System.Drawing.Size(120, 23) };
            var l9 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(150, 270), Size = new System.Drawing.Size(100, 18), Text = "Số ngày tính tiền" };
            this.numSoNgay = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(150, 290), Size = new System.Drawing.Size(90, 23), Minimum = 1, Maximum = 365, Value = 1 };
            var l10 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(250, 270), Size = new System.Drawing.Size(150, 18), Text = "Nhân viên lập" };
            this.cboNV2 = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(250, 290), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.btnLapHD = new System.Windows.Forms.Button { Location = new System.Drawing.Point(410, 288), Size = new System.Drawing.Size(120, 27), Text = "Lập hóa đơn" };
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);

            var l11 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 325), Size = new System.Drawing.Size(150, 18), Text = "Danh sách hóa đơn" };
            this.dgvHD = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 345), Size = new System.Drawing.Size(710, 110), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            this.txtHDChon = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 465), Size = new System.Drawing.Size(1, 1), Visible = false };

            var l12 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 470), Size = new System.Drawing.Size(90, 18), Text = "Mã thanh toán" };
            this.txtMaTT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(20, 490), Size = new System.Drawing.Size(110, 23) };
            var l13 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(140, 470), Size = new System.Drawing.Size(90, 18), Text = "Hình thức" };
            this.cboHT = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(140, 490), Size = new System.Drawing.Size(110, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            var l14 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(260, 470), Size = new System.Drawing.Size(90, 18), Text = "Số tiền" };
            this.numTienTT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(260, 490), Size = new System.Drawing.Size(120, 23), Maximum = 1000000000 };
            this.btnThanhToan = new System.Windows.Forms.Button { Location = new System.Drawing.Point(390, 488), Size = new System.Drawing.Size(110, 27), Text = "Thanh toán" };
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnTraPhong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(510, 488), Size = new System.Drawing.Size(140, 27), Text = "Hoàn tất trả phòng" };
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);

            this.btnDong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(660, 525), Size = new System.Drawing.Size(80, 30), Text = "Đóng" };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(756, 570);
            this.Controls.Add(l1); this.Controls.Add(this.cboDat);
            this.Controls.Add(l2); this.Controls.Add(this.dgvPhong);
            this.Controls.Add(l3); this.Controls.Add(this.dgvTN);
            this.Controls.Add(l4); this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(l5); this.Controls.Add(this.txtSoDB);
            this.Controls.Add(l6); this.Controls.Add(this.txtMucDo);
            this.Controls.Add(l7); this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.btnThemDB); this.Controls.Add(this.btnLapDB);
            this.Controls.Add(l8); this.Controls.Add(this.txtSoHD);
            this.Controls.Add(l9); this.Controls.Add(this.numSoNgay);
            this.Controls.Add(l10); this.Controls.Add(this.cboNV2);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(l11); this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(l12); this.Controls.Add(this.txtMaTT);
            this.Controls.Add(l13); this.Controls.Add(this.cboHT);
            this.Controls.Add(l14); this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.btnThanhToan); this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.Frm_Load);
        }
    }
}
