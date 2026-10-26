-- Tài khoản mẫu để chạy thử ứng dụng WinForms (mật khẩu của tất cả: 123456)
-- Chạy SAU Bai7_CSDL.sql và Bai7_DuLieuMau.sql
USE QuanLyNhanSu_DongA;
GO
DECLARE @h VARCHAR(64) = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '123456'), 2));
INSERT dbo.TaiKhoan (MaTaiKhoan, TenDangNhap, MatKhauHash, VaiTro, MaNhanVien) VALUES
 ('TK001', 'nhansu',      @h, N'NhanSu',      'NV003'),
 ('TK002', 'truongphong', @h, N'TruongPhong', 'NV007'),
 ('TK003', 'chamcong',    @h, N'ChamCong',    'NV008'),
 ('TK004', 'ketoan',      @h, N'KeToan',      'NV004'),
 ('TK005', 'giamdoc',     @h, N'GiamDoc',     'NV005');
GO
