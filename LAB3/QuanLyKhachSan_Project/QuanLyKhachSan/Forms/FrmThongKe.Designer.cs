namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtTu, dtDen;
        private System.Windows.Forms.Button btnTK, btnDong;
        private System.Windows.Forms.DataGridView dgvTongHop, dgvDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var l1 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 5), Size = new System.Drawing.Size(70, 18), Text = "Từ ngày" };
            this.dtTu = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(20, 25), Size = new System.Drawing.Size(130, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };
            var l2 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(170, 5), Size = new System.Drawing.Size(70, 18), Text = "Đến ngày" };
            this.dtDen = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(170, 25), Size = new System.Drawing.Size(130, 23), Format = System.Windows.Forms.DateTimePickerFormat.Short };
            this.btnTK = new System.Windows.Forms.Button { Location = new System.Drawing.Point(320, 23), Size = new System.Drawing.Size(100, 27), Text = "Thống kê" };
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);

            var l3 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(300, 18), Text = "Tổng hợp (phiếu đặt, đang ở, hóa đơn, doanh thu, đền bù)" };
            this.dgvTongHop = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 85), Size = new System.Drawing.Size(600, 60), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            var l4 = new System.Windows.Forms.Label { Location = new System.Drawing.Point(20, 155), Size = new System.Drawing.Size(200, 18), Text = "Dịch vụ sử dụng" };
            this.dgvDV = new System.Windows.Forms.DataGridView { Location = new System.Drawing.Point(20, 175), Size = new System.Drawing.Size(600, 230), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill };

            this.btnDong = new System.Windows.Forms.Button { Location = new System.Drawing.Point(540, 415), Size = new System.Drawing.Size(80, 30), Text = "Đóng" };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(l1); this.Controls.Add(this.dtTu);
            this.Controls.Add(l2); this.Controls.Add(this.dtDen);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(l3); this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(l4); this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.btnDong);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê khách sạn";
        }
    }
}
