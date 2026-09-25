namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboLuot, cboDV, cboNV;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnGhi, btnDong;
        private System.Windows.Forms.DataGridView dgvLichSu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var l1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(140, 18), Text = "Phiếu lưu trú (Đang ở)" };
            this.cboLuot = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(140, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);

            var l2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(180, 5), Size = new System.Drawing.Size(90, 18), Text = "Phòng" };
            this.txtPhong = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(180, 25), Size = new System.Drawing.Size(90, 23), ReadOnly = true };

            var l3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(290, 5), Size = new System.Drawing.Size(150, 18), Text = "Dịch vụ" };
            this.cboDV = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(290, 25), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };

            var l4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 55), Size = new System.Drawing.Size(120, 18), Text = "Ngày sử dụng" };
            this.dtNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(20, 75), Size = new System.Drawing.Size(140, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };

            var l5 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(180, 55), Size = new System.Drawing.Size(90, 18), Text = "Số lượng" };
            this.numSL = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(180, 75), Size = new System.Drawing.Size(90, 23), Minimum = 1, Maximum = 1000, Value = 1 };

            var l6 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(290, 55), Size = new System.Drawing.Size(150, 18), Text = "Nhân viên ghi nhận" };
            this.cboNV = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(290, 75), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };

            this.btnGhi = new System.Windows.Forms.Button { Location = new System.Drawing.Point(460, 73), Size = new System.Drawing.Size(120, 27), Text = "Ghi nhận" };
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);

            var l7 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 115), Size = new System.Drawing.Size(200, 18), Text = "Lịch sử sử dụng dịch vụ" };
            this.dgvLichSu = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 135), Size = new System.Drawing.Size(600, 300), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            this.btnDong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(540, 450), Size = new System.Drawing.Size(80, 30), Text = "Đóng" };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(650, 495);
            this.Controls.Add(l1); this.Controls.Add(this.cboLuot);
            this.Controls.Add(l2); this.Controls.Add(this.txtPhong);
            this.Controls.Add(l3); this.Controls.Add(this.cboDV);
            this.Controls.Add(l4); this.Controls.Add(this.dtNgay);
            this.Controls.Add(l5); this.Controls.Add(this.numSL);
            this.Controls.Add(l6); this.Controls.Add(this.cboNV);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(l7); this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.Frm_Load);
        }
    }
}
