namespace EShopping.Forms
{
    partial class FrmShop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Text = "e-SHOPPING";

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoGenerateColumns = true;
            this.dgvProducts.Location = new System.Drawing.Point(20, 55);
            this.dgvProducts.Size = new System.Drawing.Size(740, 300);

            this.btnAddToCart.Location = new System.Drawing.Point(20, 375);
            this.btnAddToCart.Size = new System.Drawing.Size(150, 35);
            this.btnAddToCart.Text = "Thêm vào giỏ";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            this.btnCheckout.Location = new System.Drawing.Point(190, 375);
            this.btnCheckout.Size = new System.Drawing.Size(150, 35);
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnCheckout);
            this.Name = "FrmShop";
            this.Text = "e-SHOPPING - Cửa hàng";

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
