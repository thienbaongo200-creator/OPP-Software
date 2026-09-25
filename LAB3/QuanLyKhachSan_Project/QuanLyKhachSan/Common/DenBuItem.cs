namespace QuanLyKhachSan.Services
{
    /// <summary>
    /// Một dòng tiện nghi hư hỏng/mất mát được chọn tạm thời trên FrmTraPhong
    /// trước khi lập phiếu đền bù.
    /// </summary>
    public class DenBuItem
    {
        public string MaTienNghi { get; set; }
        public string TenLoaiTN { get; set; }
        public string MucDoThietHai { get; set; }
        public decimal SoTien { get; set; }
    }
}
