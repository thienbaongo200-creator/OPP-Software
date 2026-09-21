namespace QuanLyThuVien.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblMuon = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.dgvPhat = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.labelDenNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(120, 35);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(140, 28);
            this.dtTu.TabIndex = 1;
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(390, 35);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(140, 28);
            this.dtDen.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(560, 32);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 35);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblMuon
            // 
            this.lblMuon.AutoSize = true;
            this.lblMuon.Location = new System.Drawing.Point(60, 100);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(139, 21);
            this.lblMuon.TabIndex = 5;
            this.lblMuon.Text = "Lượt sách mượn: 0";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Location = new System.Drawing.Point(430, 100);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(130, 21);
            this.lblQuaHan.TabIndex = 6;
            this.lblQuaHan.Text = "Sách quá hạn: 0";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(60, 150);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(95, 21);
            this.lblMat.TabIndex = 7;
            this.lblMat.Text = "Sách mất: 0";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Location = new System.Drawing.Point(430, 150);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(127, 21);
            this.lblHuHong.TabIndex = 8;
            this.lblHuHong.Text = "Sách hư hỏng: 0";
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhiPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.lblPhiPhat.Location = new System.Drawing.Point(60, 205);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(182, 28);
            this.lblPhiPhat.TabIndex = 9;
            this.lblPhiPhat.Text = "Tổng phí phạt: 0 đ";
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChiTiet.Location = new System.Drawing.Point(60, 260);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(155, 21);
            this.lblChiTiet.TabIndex = 10;
            this.lblChiTiet.Text = "Chi tiết phiếu phạt:";
            // 
            // dgvPhat
            // 
            this.dgvPhat.AllowUserToAddRows = false;
            this.dgvPhat.AllowUserToDeleteRows = false;
            this.dgvPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhat.Location = new System.Drawing.Point(60, 290);
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.ReadOnly = true;
            this.dgvPhat.RowHeadersWidth = 51;
            this.dgvPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhat.Size = new System.Drawing.Size(950, 330);
            this.dgvPhat.TabIndex = 11;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(910, 640);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Location = new System.Drawing.Point(40, 40);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(68, 21);
            this.labelTuNgay.TabIndex = 0;
            this.labelTuNgay.Text = "Từ ngày:";
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.AutoSize = true;
            this.labelDenNgay.Location = new System.Drawing.Point(295, 40);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Size = new System.Drawing.Size(79, 21);
            this.labelDenNgay.TabIndex = 2;
            this.labelDenNgay.Text = "Đến ngày:";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.labelDenNgay);
            this.Controls.Add(this.labelTuNgay);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblPhiPhat);
            this.Controls.Add(this.lblHuHong);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblQuaHan);
            this.Controls.Add(this.lblMuon);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.dtTu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.DataGridView dgvPhat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.Label labelDenNgay;
    }
}