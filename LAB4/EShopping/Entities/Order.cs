using System;

namespace EShopping.Entities
{
    public class Order
    {
        public int MaDH { get; set; }
        public DateTime NgayDat { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiNhan { get; set; }
        public string DienThoaiNhan { get; set; }
        public decimal TienHang { get; set; }
        public decimal PhiGiaoHang { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public string EmailXacNhan { get; set; }
    }
}
