namespace EShopping.Forms
{
    partial class FrmCart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoGenerateColumns = true;
            this.dgvCart.Location = new System.Drawing.Point(20, 20);
            this.dgvCart.Size = new System.Drawing.Size(640, 280);

            this.btnRemove.Location = new System.Drawing.Point(20, 320);
            this.btnRemove.Size = new System.Drawing.Size(140, 35);
            this.btnRemove.Text = "Xóa sản phẩm";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(200, 330);
            this.lblTotal.Text = "Tạm tính: 0 VNĐ";

            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotal);
            this.Name = "FrmCart";
            this.Text = "Giỏ hàng";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
