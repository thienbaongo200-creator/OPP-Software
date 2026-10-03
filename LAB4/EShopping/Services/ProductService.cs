using System.Collections.Generic;
using EShopping.Adapters;
using EShopping.Entities;

namespace EShopping.Services
{
    public class ProductService
    {
        private readonly ProductAdapter adapter = new ProductAdapter();

        public List<ProductInfo> TraCuuSanPham(string nhomSP)
        {
            return adapter.GetProducts(nhomSP);
        }
    }
}
