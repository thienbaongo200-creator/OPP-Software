using System.Collections.Generic;

namespace EShopping.Entities
{
    public class Cart
    {
        public int MaGioHang { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
