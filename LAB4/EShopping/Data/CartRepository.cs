using EShopping.Entities;

namespace EShopping.Data
{
    public class CartRepository
    {
        public Cart GetCurrentCart()
        {
            return new Cart();
        }

        public void Save(Cart cart)
        {
            // Prototype: bổ sung SQL khi triển khai CSDL.
        }
    }
}
