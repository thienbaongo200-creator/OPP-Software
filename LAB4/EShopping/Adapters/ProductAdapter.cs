using System.Collections.Generic;
using EShopping.Entities;

namespace EShopping.Adapters
{
    public class ProductAdapter
    {
        public List<ProductInfo> GetProducts(string group)
        {
            return new List<ProductInfo>
            {
                new ProductInfo { MaSP = "SP001", TenSP = "Laptop ABC", NhaSanXuat = "ABC", GiaBan = 15000000, TrangThaiTonKho = "Còn hàng", NhomSP = "Laptop" },
                new ProductInfo { MaSP = "SP002", TenSP = "Điện thoại ABC", NhaSanXuat = "ABC", GiaBan = 8000000, TrangThaiTonKho = "Còn hàng", NhomSP = "Điện thoại" }
            };
        }
    }
}
