using EShopping.Data;
using EShopping.Entities;

namespace EShopping.Services
{
    public class CartService
    {
        private readonly CartRepository repository = new CartRepository();
        private readonly Cart cart = new Cart();

        public Cart LayGioHang()
        {
            return cart;
        }

        public void ThemSanPham(ProductInfo product, int soLuong)
        {
            CartItem item = cart.Items.Find(x => x.MaSP == product.MaSP);
            if (item == null)
            {
                cart.Items.Add(new CartItem
                {
                    MaSP = product.MaSP,
                    TenSP = product.TenSP,
                    DonGia = product.GiaBan,
                    SoLuong = soLuong
                });
            }
            else
            {
                item.SoLuong += soLuong;
            }
            repository.Save(cart);
        }

        public void XoaSanPham(string maSP)
        {
            cart.Items.RemoveAll(x => x.MaSP == maSP);
            repository.Save(cart);
        }
    }
}
