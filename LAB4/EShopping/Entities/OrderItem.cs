namespace EShopping.Entities
{
    public class OrderItem
    {
        public int MaDH { get; set; }
        public string MaSP { get; set; }
        public string TenSPSnapshot { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }
    }
}
