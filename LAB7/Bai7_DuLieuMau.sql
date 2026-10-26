-- =====================================================================
-- DỮ LIỆU MẪU CHO KỊCH BẢN KIỂM THỬ (tháng 10/2026)
-- =====================================================================
USE QuanLyNhanSu_DongA;
GO
INSERT dbo.PhongBan (MaPhongBan, TenPhongBan) VALUES
 ('PB01', N'Phân xưởng sản xuất'), ('PB02', N'Phòng Nhân sự'), ('PB03', N'Phòng Kế toán');
INSERT dbo.NhanVien (MaNhanVien, HoTen, NgayVaoLam, TrangThai, MaPhongBan) VALUES
 ('NV001', N'Nguyễn Văn An',   '2024-03-01', N'ChinhThuc', 'PB01'),
 ('NV002', N'Trần Thị Bình',   '2025-06-01', N'ChinhThuc', 'PB01'),
 ('NV003', N'Lê Minh Cường',   '2022-01-10', N'ChinhThuc', 'PB02'),
 ('NV004', N'Phạm Thu Dung',   '2022-05-15', N'ChinhThuc', 'PB03'),
 ('NV005', N'Hoàng Gia Huy',   '2020-01-01', N'ChinhThuc', 'PB02'),
 ('NV006', N'Võ Quốc Khánh',   '2026-10-01', N'ThuViec',   'PB01'),
 ('NV007', N'Đặng Văn Lộc',    '2021-08-01', N'ChinhThuc', 'PB01'),
 ('NV008', N'Bùi Thị Hoa',     '2023-02-01', N'ChinhThuc', 'PB02');   -- ban chấm công
INSERT dbo.TyLeBaoHiem VALUES ('TL01', '2025-01-01', NULL, 0.0800, 0.0150);
INSERT dbo.CaLam VALUES ('CA01', N'Ca hành chính', '07:30', '16:30');
INSERT dbo.HopDongLaoDong VALUES
 ('HD001','NV001',N'DaiHan', '2024-03-01', NULL,        9360000, N'HieuLuc'),
 ('HD002','NV002',N'NganHan','2025-06-01', '2026-11-20', 7280000, N'HieuLuc');
INSERT dbo.HoSoBaoHiem VALUES ('BH001','NV001','HD001','BHXH0001','BHYT0001', 9360000, '2024-03-01', N'DangThamGia');
INSERT dbo.QuyetDinhLuong (MaQuyetDinhLuong, MaNhanVien, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, NguoiKy, TrangThaiDuyet) VALUES
 ('QL001','NV001','2024-03-01', 9360000, 500000, 300000, 'NV005', N'DaDuyet'),
 ('QL002','NV002','2025-06-01', 7280000, 200000,      0, 'NV005', N'DaDuyet');
INSERT dbo.QuyetDinhChucVu (MaQuyetDinhCV, MaNhanVien, ChucVu, PhuCapChucVu, NgayHieuLuc, NguoiKy, TrangThaiDuyet) VALUES
 ('CV001','NV001',N'Công nhân', 0, '2024-03-01', 'NV005', N'DaDuyet');
-- Chấm công: NV001 = 25 ngày x 8 giờ = 200 giờ (bỏ 12/10 và 26/10); NV002 = 26 ngày x 8 giờ = 208 giờ (bỏ 31/10)
;WITH d AS (SELECT CAST('2026-10-01' AS DATE) AS Ngay UNION ALL SELECT DATEADD(DAY,1,Ngay) FROM d WHERE Ngay < '2026-10-31')
INSERT dbo.BangChamCong (MaChamCong, MaNhanVien, NgayCong, MaCa, SoGioCong, TrangThai, NguoiXacNhan)
SELECT 'CC1' + FORMAT(Ngay,'MMdd'), 'NV001', Ngay, 'CA01', 8, N'DaXacNhan', 'NV007'
FROM d WHERE DATEDIFF(DAY,'19000101',Ngay) % 7 <> 6 AND Ngay NOT IN ('2026-10-12','2026-10-26') OPTION (MAXRECURSION 40);
;WITH d AS (SELECT CAST('2026-10-01' AS DATE) AS Ngay UNION ALL SELECT DATEADD(DAY,1,Ngay) FROM d WHERE Ngay < '2026-10-31')
INSERT dbo.BangChamCong (MaChamCong, MaNhanVien, NgayCong, MaCa, SoGioCong, TrangThai, NguoiXacNhan)
SELECT 'CC2' + FORMAT(Ngay,'MMdd'), 'NV002', Ngay, 'CA01', 8, N'DaXacNhan', 'NV007'
FROM d WHERE DATEDIFF(DAY,'19000101',Ngay) % 7 <> 6 AND Ngay <> '2026-10-31' OPTION (MAXRECURSION 40);
INSERT dbo.PhieuPhuTroi (MaPhieuPhuTroi, NgayPhuTroi, TongSoGio, HinhThuc, NguoiLap, TrangThaiDuyet) VALUES
 ('PT001','2026-10-17', 6, N'NgayNghi', 'NV008', N'DaDuyet'),
 ('PT002','2026-10-20', 4, N'TangCa',   'NV008', N'DaDuyet');
INSERT dbo.ChiTietPhuTroi (MaChiTietPT, MaPhieuPhuTroi, MaNhanVien, SoGio) VALUES ('CT001','PT001','NV001',6), ('CT002','PT002','NV001',4);
INSERT dbo.QuyetDinhKhenThuong (MaQuyetDinhKT, PhamVi, LoaiKhenThuong, MaNhanVien, MaPhongBan, LyDo, SoTien, NgayQuyetDinh, NguoiLap, NguoiKy, TrangThaiDuyet)
VALUES ('KT001',N'CaNhan',N'ThanhTich','NV001',NULL,N'Hoàn thành vượt tiến độ lô sơn Q3',500000,'2026-10-05','NV007','NV005',N'DaDuyet');
INSERT dbo.PhieuThuChi (MaPhieuThuChi, LoaiPhieu, NgayLap, SoTien, NoiDung, MaQuyetDinhKT, NguoiLap, NguoiDuyet, TrangThai)
VALUES ('PC0001', N'Chi', '2026-10-05', 500000, N'Chi khen thưởng KT001', 'KT001', 'NV004', 'NV005', N'DaDuyet');
INSERT dbo.QuyetDinhKyLuat  VALUES ('KL001',N'CaNhan',N'PhatTien','NV001',NULL,N'Vi phạm nội quy an toàn',200000,N'TruLuong','2026-10-08','NV007','NV005',N'DaDuyet');
INSERT dbo.DieuChinhLuong (MaDieuChinh, MaNhanVien, KyLuong, LoaiDieuChinh, SoTien, MaQuyetDinhKL) VALUES
 ('DC001','NV001','2026-10',N'Phat', 200000,'KL001');
GO
-- Chạy thử: EXEC dbo.sp_TinhLuongThang @Thang = 10, @Nam = 2026, @NguoiLap = 'NV004';
-- Kết quả mong đợi: xem test case TC14 trong báo cáo (NV001 thực lĩnh 9.385.800; NV002 thực lĩnh 7.480.000)
