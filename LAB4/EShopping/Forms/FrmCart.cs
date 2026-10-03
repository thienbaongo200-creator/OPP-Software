using System;
using System.Linq;
using System.Windows.Forms;
using EShopping.Entities;
using EShopping.Services;

namespace EShopping.Forms
{
    public partial class FrmCart : Form
    {
        private readonly CartService cartService = new CartService();

        public FrmCart()
        {
            InitializeComponent();
            RefreshCart();
        }

        public FrmCart(ProductInfo product) : this()
        {
            if (product != null)
                cartService.ThemSanPham(product, 1);
            RefreshCart();
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cartService.LayGioHang().Items.ToList();
            lblTotal.Text = "Tạm tính: " + cartService.LayGioHang().Items.Sum(x => x.ThanhTien).ToString("N0") + " VNĐ";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;
            CartItem item = dgvCart.CurrentRow.DataBoundItem as CartItem;
            if (item == null) return;

            cartService.XoaSanPham(item.MaSP);
            RefreshCart();
        }
    }
}
