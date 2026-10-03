namespace EShopping.Forms
{
    partial class FrmCheckout
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCardNumber;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblRecipient.Text = "Người nhận";
            this.lblRecipient.Location = new System.Drawing.Point(20, 20);
            this.txtRecipient.Location = new System.Drawing.Point(150, 17);
            this.txtRecipient.Size = new System.Drawing.Size(300, 22);

            this.lblAddress.Text = "Địa chỉ";
            this.lblAddress.Location = new System.Drawing.Point(20, 55);
            this.txtAddress.Location = new System.Drawing.Point(150, 52);
            this.txtAddress.Size = new System.Drawing.Size(300, 22);

            this.lblPhone.Text = "Điện thoại";
            this.lblPhone.Location = new System.Drawing.Point(20, 90);
            this.txtPhone.Location = new System.Drawing.Point(150, 87);
            this.txtPhone.Size = new System.Drawing.Size(300, 22);

            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(20, 125);
            this.txtEmail.Location = new System.Drawing.Point(150, 122);
            this.txtEmail.Size = new System.Drawing.Size(300, 22);

            this.lblAmount.Text = "Tổng tiền";
            this.lblAmount.Location = new System.Drawing.Point(20, 160);
            this.txtAmount.Location = new System.Drawing.Point(150, 157);
            this.txtAmount.Size = new System.Drawing.Size(300, 22);

            this.lblCardType.Text = "Loại thẻ";
            this.lblCardType.Location = new System.Drawing.Point(20, 195);
            this.cboCardType.Location = new System.Drawing.Point(150, 192);
            this.cboCardType.Size = new System.Drawing.Size(180, 24);
            this.cboCardType.Items.AddRange(new object[] { "VISA", "Master", "Discover", "AmEx" });
            this.cboCardType.SelectedIndex = 0;

            this.lblCardNumber.Text = "Số thẻ";
            this.lblCardNumber.Location = new System.Drawing.Point(20, 230);
            this.txtCardNumber.Location = new System.Drawing.Point(150, 227);
            this.txtCardNumber.Size = new System.Drawing.Size(300, 22);

            this.btnPay.Location = new System.Drawing.Point(150, 270);
            this.btnPay.Size = new System.Drawing.Size(150, 35);
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);

            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblRecipient, this.txtRecipient,
                this.lblAddress, this.txtAddress,
                this.lblPhone, this.txtPhone,
                this.lblEmail, this.txtEmail,
                this.lblAmount, this.txtAmount,
                this.lblCardType, this.cboCardType,
                this.lblCardNumber, this.txtCardNumber,
                this.btnPay
            });
            this.Name = "FrmCheckout";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
