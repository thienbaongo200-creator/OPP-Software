using System;
using System.Windows.Forms;
using EShopping.Entities;
using EShopping.Services;

namespace EShopping.Forms
{
    public partial class FrmShop : Form
    {
        private readonly ProductService productService = new ProductService();

        public FrmShop()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = productService.TraCuuSanPham(null);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            ProductInfo product = dgvProducts.CurrentRow.DataBoundItem as ProductInfo;
            if (product == null) return;

            using (FrmCart frm = new FrmCart(product))
            {
                frm.ShowDialog();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            using (FrmCheckout frm = new FrmCheckout())
            {
                frm.ShowDialog();
            }
        }
    }
}
