namespace QuanLyKhachSan.Services
{
    /// <summary>
    /// Một dòng phòng được chọn tạm thời trên FrmDatPhong trước khi lập phiếu đặt phòng.
    /// </summary>
    public class PhongDatItem
    {
        public string SoPhong { get; set; }
        public int SoNguoi { get; set; }
        public decimal DonGiaNgay { get; set; }
    }
}
