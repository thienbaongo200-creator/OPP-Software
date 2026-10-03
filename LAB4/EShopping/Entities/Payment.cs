namespace EShopping.Entities
{
    public class Payment
    {
        public string LoaiThe { get; set; }
        public string MaskedCard { get; set; }
        public string PaymentReference { get; set; }
        public decimal SoTien { get; set; }
        public string TrangThai { get; set; }
    }
}
