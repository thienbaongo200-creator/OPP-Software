namespace QuanLyKhachSan.Services
{
    /// <summary>
    /// Kết quả trả về chuẩn hóa cho các thao tác xử lý nghiệp vụ trong Service.
    /// ThanhCong = true khi thao tác hợp lệ; ThongBao chứa thông điệp hiển thị cho người dùng.
    /// </summary>
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao };
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao };
        }
    }
}
