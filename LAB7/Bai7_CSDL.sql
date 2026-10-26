-- =====================================================================
-- BÀI 7: QUẢN LÝ NHÂN SỰ VÀ TIỀN LƯƠNG – CÔNG TY SƠN ĐÔNG Á
-- CSDL SQL Server (từ 2016 SP1 trở lên) – nhất quán với mô hình lớp
-- =====================================================================
CREATE DATABASE QuanLyNhanSu_DongA;
GO
USE QuanLyNhanSu_DongA;
GO

-- 1. PhongBan ----------------------------------------------------------
CREATE TABLE dbo.PhongBan (
    MaPhongBan   VARCHAR(12)   NOT NULL CONSTRAINT PK_PhongBan PRIMARY KEY,
    TenPhongBan  NVARCHAR(100) NOT NULL,
    MoTa         NVARCHAR(255) NULL,
    TrangThai    NVARCHAR(20)  NOT NULL CONSTRAINT DF_PhongBan_TT DEFAULT N'HoatDong'
);

-- 2. NhanVien ----------------------------------------------------------
CREATE TABLE dbo.NhanVien (
    MaNhanVien   VARCHAR(12)   NOT NULL CONSTRAINT PK_NhanVien PRIMARY KEY,
    HoTen        NVARCHAR(100) NOT NULL,
    NgaySinh     DATE          NULL,
    GioiTinh     NVARCHAR(5)   NULL,
    DienThoai    VARCHAR(15)   NULL,
    Email        VARCHAR(100)  NULL,
    DiaChi       NVARCHAR(255) NULL,
    NgayVaoLam   DATE          NULL,
    TrangThai    NVARCHAR(20)  NOT NULL CONSTRAINT DF_NhanVien_TT DEFAULT N'UngVien',
    MaPhongBan   VARCHAR(12)   NOT NULL CONSTRAINT FK_NhanVien_PhongBan REFERENCES dbo.PhongBan(MaPhongBan),
    CONSTRAINT CK_NhanVien_TT CHECK (TrangThai IN (N'UngVien',N'ThuViec',N'ChinhThuc',N'NghiViec'))
);

-- 3. TaiKhoan (BR18) ---------------------------------------------------
CREATE TABLE dbo.TaiKhoan (
    MaTaiKhoan   VARCHAR(12)   NOT NULL CONSTRAINT PK_TaiKhoan PRIMARY KEY,
    TenDangNhap  VARCHAR(50)   NOT NULL CONSTRAINT UQ_TaiKhoan_TenDN UNIQUE,
    MatKhauHash  VARCHAR(255)  NOT NULL,
    VaiTro       NVARCHAR(20)  NOT NULL,
    MaNhanVien   VARCHAR(12)   NULL CONSTRAINT FK_TaiKhoan_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThai    NVARCHAR(20)  NOT NULL CONSTRAINT DF_TaiKhoan_TT DEFAULT N'HoatDong',
    CONSTRAINT CK_TaiKhoan_VaiTro CHECK (VaiTro IN (N'NhanSu',N'TruongPhong',N'ChamCong',N'KeToan',N'GiamDoc'))
);
CREATE UNIQUE INDEX UX_TaiKhoan_NhanVien ON dbo.TaiKhoan(MaNhanVien) WHERE MaNhanVien IS NOT NULL;

-- 4. TyLeBaoHiem (cấu hình mức đóng) ------------------------------------
CREATE TABLE dbo.TyLeBaoHiem (
    MaTyLeBH     VARCHAR(12)   NOT NULL CONSTRAINT PK_TyLeBaoHiem PRIMARY KEY,
    TuNgay       DATE          NOT NULL,
    DenNgay      DATE          NULL,
    TyLeBHXH_NV  DECIMAL(5,4)  NOT NULL,
    TyLeBHYT_NV  DECIMAL(5,4)  NOT NULL,
    CONSTRAINT CK_TyLeBH_Ngay CHECK (DenNgay IS NULL OR DenNgay >= TuNgay),
    CONSTRAINT CK_TyLeBH_TyLe CHECK (TyLeBHXH_NV BETWEEN 0 AND 1 AND TyLeBHYT_NV BETWEEN 0 AND 1)
);

-- 5. QuyetDinhTuyenDung (BR01) -------------------------------------------
CREATE TABLE dbo.QuyetDinhTuyenDung (
    MaQuyetDinhTD      VARCHAR(12)   NOT NULL CONSTRAINT PK_QDTD PRIMARY KEY,
    MaNhanVien         VARCHAR(12)   NOT NULL CONSTRAINT FK_QDTD_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    MaPhongBan         VARCHAR(12)   NOT NULL CONSTRAINT FK_QDTD_PhongBan REFERENCES dbo.PhongBan(MaPhongBan),
    NgayQuyetDinh      DATE          NOT NULL,
    NgayBatDauThuViec  DATE          NOT NULL,
    NgayKetThucThuViec DATE          NOT NULL,
    LuongThuViec       DECIMAL(18,2) NOT NULL,
    DieuKhoan          NVARCHAR(500) NOT NULL,
    NguoiKy            VARCHAR(12)   NULL CONSTRAINT FK_QDTD_NguoiKy REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet     NVARCHAR(20)  NOT NULL CONSTRAINT DF_QDTD_TT DEFAULT N'ChoDuyet',
    CONSTRAINT CK_QDTD_Ngay  CHECK (NgayKetThucThuViec >= NgayBatDauThuViec),
    CONSTRAINT CK_QDTD_Luong CHECK (LuongThuViec > 0),
    CONSTRAINT CK_QDTD_TT    CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi'))
);

-- 6. HopDongLaoDong (BR02, BR03) -----------------------------------------
CREATE TABLE dbo.HopDongLaoDong (
    MaHopDong      VARCHAR(12)   NOT NULL CONSTRAINT PK_HopDong PRIMARY KEY,
    MaNhanVien     VARCHAR(12)   NOT NULL CONSTRAINT FK_HopDong_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    LoaiHopDong    NVARCHAR(10)  NOT NULL,
    NgayBatDau     DATE          NOT NULL,
    NgayKetThuc    DATE          NULL,
    LuongThoaThuan DECIMAL(18,2) NOT NULL,
    TrangThai      NVARCHAR(20)  NOT NULL CONSTRAINT DF_HopDong_TT DEFAULT N'HieuLuc',
    CONSTRAINT CK_HopDong_Loai CHECK (LoaiHopDong IN (N'NganHan',N'DaiHan')),
    CONSTRAINT CK_HopDong_Ngay CHECK (NgayKetThuc IS NULL OR NgayKetThuc >= NgayBatDau),
    CONSTRAINT CK_HopDong_Luong CHECK (LuongThoaThuan > 0),
    CONSTRAINT CK_HopDong_TT CHECK (TrangThai IN (N'HieuLuc',N'HetHan',N'ChamDut'))
);

-- 8. HoSoBaoHiem (BR04) --------------------------------------------------
CREATE TABLE dbo.HoSoBaoHiem (
    MaHoSoBH      VARCHAR(12)   NOT NULL CONSTRAINT PK_HoSoBH PRIMARY KEY,
    MaNhanVien    VARCHAR(12)   NOT NULL CONSTRAINT FK_HoSoBH_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    MaHopDong     VARCHAR(12)   NOT NULL CONSTRAINT FK_HoSoBH_HopDong REFERENCES dbo.HopDongLaoDong(MaHopDong),
    SoBHXH        VARCHAR(20)   NOT NULL,
    SoBHYT        VARCHAR(20)   NOT NULL,
    MucLuongDong  DECIMAL(18,2) NOT NULL,
    NgayThamGia   DATE          NOT NULL,
    TrangThai     NVARCHAR(20)  NOT NULL CONSTRAINT DF_HoSoBH_TT DEFAULT N'DangThamGia',
    CONSTRAINT CK_HoSoBH_Muc CHECK (MucLuongDong > 0),
    CONSTRAINT CK_HoSoBH_TT  CHECK (TrangThai IN (N'DangThamGia',N'NgungThamGia'))
);

-- 9. QuyetDinhLuong (BR05, BR06, BR17) -----------------------------------
CREATE TABLE dbo.QuyetDinhLuong (
    MaQuyetDinhLuong   VARCHAR(12)   NOT NULL CONSTRAINT PK_QDLuong PRIMARY KEY,
    MaNhanVien         VARCHAR(12)   NOT NULL CONSTRAINT FK_QDLuong_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    NgayHieuLuc        DATE          NOT NULL,
    LuongCoBan         DECIMAL(18,2) NOT NULL,
    PhuCapLuong        DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDLuong_PC DEFAULT 0,
    PhuCapDocHai       DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDLuong_DH DEFAULT 0,
    LyDo               NVARCHAR(255) NULL,
    NguoiKy            VARCHAR(12)   NULL CONSTRAINT FK_QDLuong_NguoiKy REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet     NVARCHAR(20)  NOT NULL CONSTRAINT DF_QDLuong_TT DEFAULT N'ChoDuyet',
    MaQuyetDinhThayThe VARCHAR(12)   NULL CONSTRAINT FK_QDLuong_ThayThe REFERENCES dbo.QuyetDinhLuong(MaQuyetDinhLuong),
    CONSTRAINT CK_QDLuong_Tien CHECK (LuongCoBan > 0 AND PhuCapLuong >= 0 AND PhuCapDocHai >= 0),
    CONSTRAINT CK_QDLuong_TT   CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi',N'DaThayThe'))
);

-- 10. QuyetDinhChucVu ------------------------------------------------------
CREATE TABLE dbo.QuyetDinhChucVu (
    MaQuyetDinhCV      VARCHAR(12)   NOT NULL CONSTRAINT PK_QDChucVu PRIMARY KEY,
    MaNhanVien         VARCHAR(12)   NOT NULL CONSTRAINT FK_QDCV_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    ChucVu             NVARCHAR(100) NOT NULL,
    PhuCapChucVu       DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDCV_PC DEFAULT 0,
    NgayHieuLuc        DATE          NOT NULL,
    NguoiKy            VARCHAR(12)   NULL CONSTRAINT FK_QDCV_NguoiKy REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet     NVARCHAR(20)  NOT NULL CONSTRAINT DF_QDCV_TT DEFAULT N'ChoDuyet',
    MaQuyetDinhThayThe VARCHAR(12)   NULL CONSTRAINT FK_QDCV_ThayThe REFERENCES dbo.QuyetDinhChucVu(MaQuyetDinhCV),
    CONSTRAINT CK_QDCV_PC CHECK (PhuCapChucVu >= 0),
    CONSTRAINT CK_QDCV_TT CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi',N'DaThayThe'))
);

-- 11. CaLam ------------------------------------------------------------------
CREATE TABLE dbo.CaLam (
    MaCa        VARCHAR(12)  NOT NULL CONSTRAINT PK_CaLam PRIMARY KEY,
    TenCa       NVARCHAR(50) NOT NULL,
    GioBatDau   TIME         NOT NULL,
    GioKetThuc  TIME         NOT NULL
);

-- 12. KeHoachTuan (BR10) -----------------------------------------------------
CREATE TABLE dbo.KeHoachTuan (
    MaKeHoach   VARCHAR(12)  NOT NULL CONSTRAINT PK_KeHoachTuan PRIMARY KEY,
    MaPhongBan  VARCHAR(12)  NOT NULL CONSTRAINT FK_KHT_PhongBan REFERENCES dbo.PhongBan(MaPhongBan),
    TuNgay      DATE         NOT NULL,
    DenNgay     DATE         NOT NULL,
    NguoiLap    VARCHAR(12)  NOT NULL CONSTRAINT FK_KHT_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThai   NVARCHAR(20) NOT NULL CONSTRAINT DF_KHT_TT DEFAULT N'Nhap',
    CONSTRAINT CK_KHT_Ngay CHECK (DenNgay >= TuNgay),
    CONSTRAINT CK_KHT_TT   CHECK (TrangThai IN (N'Nhap',N'DaGui',N'DaXacNhan'))
);

-- 13. PhanCongCa ---------------------------------------------------------------
CREATE TABLE dbo.PhanCongCa (
    MaPhanCong      VARCHAR(12)  NOT NULL CONSTRAINT PK_PhanCongCa PRIMARY KEY,
    MaKeHoach       VARCHAR(12)  NOT NULL CONSTRAINT FK_PC_KeHoach REFERENCES dbo.KeHoachTuan(MaKeHoach) ON DELETE CASCADE,
    MaNhanVien      VARCHAR(12)  NOT NULL CONSTRAINT FK_PC_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    MaCa            VARCHAR(12)  NOT NULL CONSTRAINT FK_PC_Ca REFERENCES dbo.CaLam(MaCa),
    NgayLam         DATE         NOT NULL,
    DuKienPhuTroi   DECIMAL(5,2) NOT NULL CONSTRAINT DF_PC_PT DEFAULT 0,
    CONSTRAINT UQ_PhanCong UNIQUE (MaNhanVien, NgayLam, MaCa),
    CONSTRAINT CK_PC_PT CHECK (DuKienPhuTroi BETWEEN 0 AND 12)
);

-- 14. BangChamCong ---------------------------------------------------------------
CREATE TABLE dbo.BangChamCong (
    MaChamCong   VARCHAR(12)  NOT NULL CONSTRAINT PK_ChamCong PRIMARY KEY,
    MaNhanVien   VARCHAR(12)  NOT NULL CONSTRAINT FK_CC_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    NgayCong     DATE         NOT NULL,
    MaCa         VARCHAR(12)  NOT NULL CONSTRAINT FK_CC_Ca REFERENCES dbo.CaLam(MaCa),
    GioVao       TIME         NULL,
    GioRa        TIME         NULL,
    SoGioCong    DECIMAL(5,2) NOT NULL,
    TrangThai    NVARCHAR(20) NOT NULL CONSTRAINT DF_CC_TT DEFAULT N'ChoXacNhan',
    NguoiXacNhan VARCHAR(12)  NULL CONSTRAINT FK_CC_NguoiXN REFERENCES dbo.NhanVien(MaNhanVien),
    CONSTRAINT UQ_ChamCong UNIQUE (MaNhanVien, NgayCong, MaCa),
    CONSTRAINT CK_CC_Gio CHECK (SoGioCong BETWEEN 0 AND 24),
    CONSTRAINT CK_CC_TT  CHECK (TrangThai IN (N'ChoXacNhan',N'DaXacNhan'))
);

-- 15. PhieuPhuTroi (BR08) ------------------------------------------------------------
CREATE TABLE dbo.PhieuPhuTroi (
    MaPhieuPhuTroi VARCHAR(12)  NOT NULL CONSTRAINT PK_PhieuPhuTroi PRIMARY KEY,
    NgayPhuTroi    DATE         NOT NULL,
    TongSoGio      DECIMAL(7,2) NOT NULL CONSTRAINT DF_PPT_Gio DEFAULT 0,   -- tổng số giờ phụ trội của phiếu
    HinhThuc       NVARCHAR(20) NOT NULL,                                    -- tăng ca, ngày lễ, ngày nghỉ
    NguoiLap       VARCHAR(12)  NOT NULL CONSTRAINT FK_PPT_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet NVARCHAR(20) NOT NULL CONSTRAINT DF_PPT_TT DEFAULT N'ChoDuyet',
    CONSTRAINT CK_PPT_HT CHECK (HinhThuc IN (N'TangCa',N'NgayLe',N'NgayNghi')),
    CONSTRAINT CK_PPT_Gio CHECK (TongSoGio >= 0),
    CONSTRAINT CK_PPT_TT CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi'))
);

-- 16. ChiTietPhuTroi (BR09: giờ quy đổi = 1,5 x số giờ) ------------------------------
CREATE TABLE dbo.ChiTietPhuTroi (
    MaChiTietPT    VARCHAR(12)  NOT NULL CONSTRAINT PK_ChiTietPT PRIMARY KEY,
    MaPhieuPhuTroi VARCHAR(12)  NOT NULL CONSTRAINT FK_CTPT_Phieu REFERENCES dbo.PhieuPhuTroi(MaPhieuPhuTroi) ON DELETE CASCADE,
    MaNhanVien     VARCHAR(12)  NOT NULL CONSTRAINT FK_CTPT_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    SoGio          DECIMAL(5,2) NOT NULL,
    GioQuyDoi      AS CAST(SoGio * 1.5 AS DECIMAL(7,2)) PERSISTED,
    CONSTRAINT UQ_CTPT UNIQUE (MaPhieuPhuTroi, MaNhanVien),
    CONSTRAINT CK_CTPT_Gio CHECK (SoGio > 0 AND SoGio <= 12)
);

-- 17. QuyetDinhKhenThuong (BR11, BR13) – chi tiền qua phiếu chi khen thưởng -------------------------------------------------
CREATE TABLE dbo.QuyetDinhKhenThuong (
    MaQuyetDinhKT  VARCHAR(12)   NOT NULL CONSTRAINT PK_QDKT PRIMARY KEY,
    PhamVi         NVARCHAR(10)  NOT NULL,
    LoaiKhenThuong NVARCHAR(20)  NOT NULL,
    MaNhanVien     VARCHAR(12)   NULL CONSTRAINT FK_QDKT_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    MaPhongBan     VARCHAR(12)   NULL CONSTRAINT FK_QDKT_PhongBan REFERENCES dbo.PhongBan(MaPhongBan),
    LyDo           NVARCHAR(255) NOT NULL,
    SoTien         DECIMAL(18,2) NOT NULL,
    NgayQuyetDinh  DATE          NOT NULL,
    NguoiLap       VARCHAR(12)   NOT NULL CONSTRAINT FK_QDKT_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    NguoiKy        VARCHAR(12)   NULL CONSTRAINT FK_QDKT_NguoiKy REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet NVARCHAR(20)  NOT NULL CONSTRAINT DF_QDKT_TT DEFAULT N'ChoDuyet',
    CONSTRAINT CK_QDKT_PhamVi CHECK (
        (PhamVi = N'CaNhan'   AND MaNhanVien IS NOT NULL AND MaPhongBan IS NULL) OR
        (PhamVi = N'PhongBan' AND MaPhongBan IS NOT NULL AND MaNhanVien IS NULL)),
    CONSTRAINT CK_QDKT_Loai CHECK (LoaiKhenThuong IN (N'Le',N'CuoiNam',N'Thang13',N'ThanhTich')),
    CONSTRAINT CK_QDKT_Tien CHECK (SoTien > 0),
    CONSTRAINT CK_QDKT_TT   CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi'))
);

-- 18. QuyetDinhKyLuat (BR12) -------------------------------------------------------------
CREATE TABLE dbo.QuyetDinhKyLuat (
    MaQuyetDinhKL  VARCHAR(12)   NOT NULL CONSTRAINT PK_QDKL PRIMARY KEY,
    PhamVi         NVARCHAR(10)  NOT NULL,
    HinhThucKyLuat NVARCHAR(20)  NOT NULL,
    MaNhanVien     VARCHAR(12)   NULL CONSTRAINT FK_QDKL_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    MaPhongBan     VARCHAR(12)   NULL CONSTRAINT FK_QDKL_PhongBan REFERENCES dbo.PhongBan(MaPhongBan),
    LyDo           NVARCHAR(255) NOT NULL,
    SoTien         DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDKL_Tien DEFAULT 0,
    HinhThucThu    NVARCHAR(20)  NOT NULL,
    NgayQuyetDinh  DATE          NOT NULL,
    NguoiLap       VARCHAR(12)   NOT NULL CONSTRAINT FK_QDKL_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    NguoiKy        VARCHAR(12)   NULL CONSTRAINT FK_QDKL_NguoiKy REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThaiDuyet NVARCHAR(20)  NOT NULL CONSTRAINT DF_QDKL_TT DEFAULT N'ChoDuyet',
    CONSTRAINT CK_QDKL_PhamVi CHECK (
        (PhamVi = N'CaNhan'   AND MaNhanVien IS NOT NULL AND MaPhongBan IS NULL) OR
        (PhamVi = N'PhongBan' AND MaPhongBan IS NOT NULL AND MaNhanVien IS NULL)),
    CONSTRAINT CK_QDKL_HT   CHECK (HinhThucKyLuat IN (N'KhienTrach',N'CanhCao',N'PhatTien')),
    CONSTRAINT CK_QDKL_Thu  CHECK (HinhThucThu IN (N'PhieuThu',N'TruLuong',N'KhongThu')),
    CONSTRAINT CK_QDKL_Tien CHECK (SoTien >= 0 AND (HinhThucThu = N'KhongThu' OR SoTien > 0)),
    CONSTRAINT CK_QDKL_TT   CHECK (TrangThaiDuyet IN (N'ChoDuyet',N'DaDuyet',N'TuChoi'))
);

-- 19. PhieuThuChi ----------------------------------------------------------------------------
CREATE TABLE dbo.PhieuThuChi (
    MaPhieuThuChi  VARCHAR(12)   NOT NULL CONSTRAINT PK_PhieuThuChi PRIMARY KEY,
    LoaiPhieu      NVARCHAR(5)   NOT NULL,
    NgayLap        DATE          NOT NULL,
    SoTien         DECIMAL(18,2) NOT NULL,
    NoiDung        NVARCHAR(255) NOT NULL,
    MaQuyetDinhKT  VARCHAR(12)   NULL CONSTRAINT FK_PTC_KT REFERENCES dbo.QuyetDinhKhenThuong(MaQuyetDinhKT),
    MaQuyetDinhKL  VARCHAR(12)   NULL CONSTRAINT FK_PTC_KL REFERENCES dbo.QuyetDinhKyLuat(MaQuyetDinhKL),
    NguoiLap       VARCHAR(12)   NOT NULL CONSTRAINT FK_PTC_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    NguoiDuyet     VARCHAR(12)   NULL CONSTRAINT FK_PTC_NguoiDuyet REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThai      NVARCHAR(20)  NOT NULL CONSTRAINT DF_PTC_TT DEFAULT N'ChoDuyet',
    CONSTRAINT CK_PTC_Loai   CHECK (LoaiPhieu IN (N'Chi',N'Thu')),
    CONSTRAINT CK_PTC_Tien   CHECK (SoTien > 0),
    CONSTRAINT CK_PTC_Nguon  CHECK (
        (LoaiPhieu = N'Chi' AND MaQuyetDinhKT IS NOT NULL AND MaQuyetDinhKL IS NULL) OR
        (LoaiPhieu = N'Thu' AND MaQuyetDinhKL IS NOT NULL AND MaQuyetDinhKT IS NULL)),
    CONSTRAINT CK_PTC_TT     CHECK (TrangThai IN (N'ChoDuyet',N'DaDuyet',N'Huy'))
);

-- 20. DieuChinhLuong (khoản trừ vào lương: phạt theo quyết định kỷ luật, khấu trừ khác) -----------------------------------------------------------------------------
CREATE TABLE dbo.DieuChinhLuong (
    MaDieuChinh    VARCHAR(12)   NOT NULL CONSTRAINT PK_DieuChinhLuong PRIMARY KEY,
    MaNhanVien     VARCHAR(12)   NOT NULL CONSTRAINT FK_DCL_NhanVien REFERENCES dbo.NhanVien(MaNhanVien),
    KyLuong        CHAR(7)       NOT NULL,   -- định dạng yyyy-MM
    LoaiDieuChinh  NVARCHAR(20)  NOT NULL,
    SoTien         DECIMAL(18,2) NOT NULL,
    MaQuyetDinhKL  VARCHAR(12)   NULL CONSTRAINT FK_DCL_KL REFERENCES dbo.QuyetDinhKyLuat(MaQuyetDinhKL),
    TrangThai      NVARCHAR(20)  NOT NULL CONSTRAINT DF_DCL_TT DEFAULT N'ChoApDung',
    CONSTRAINT CK_DCL_Loai CHECK (LoaiDieuChinh IN (N'Phat',N'KhauTruKhac')),
    CONSTRAINT CK_DCL_Tien CHECK (SoTien > 0),
    CONSTRAINT CK_DCL_TT   CHECK (TrangThai IN (N'ChoApDung',N'DaApDung',N'Huy'))
);

-- 21. BangLuong (BR16) ----------------------------------------------------------------------------
CREATE TABLE dbo.BangLuong (
    MaBangLuong   VARCHAR(12)   NOT NULL CONSTRAINT PK_BangLuong PRIMARY KEY,
    Thang         INT           NOT NULL,
    Nam           INT           NOT NULL,
    NgayLap       DATE          NOT NULL,
    NguoiLap      VARCHAR(12)   NOT NULL CONSTRAINT FK_BL_NguoiLap REFERENCES dbo.NhanVien(MaNhanVien),
    TrangThai     NVARCHAR(20)  NOT NULL CONSTRAINT DF_BL_TT DEFAULT N'Nhap',
    TongLuong     DECIMAL(18,2) NOT NULL CONSTRAINT DF_BL_TL DEFAULT 0,
    TongKhauTru   DECIMAL(18,2) NOT NULL CONSTRAINT DF_BL_KT DEFAULT 0,
    TongThucLinh  DECIMAL(18,2) NOT NULL CONSTRAINT DF_BL_TLinh DEFAULT 0,
    CONSTRAINT UQ_BangLuong_KyLuong UNIQUE (Thang, Nam),
    CONSTRAINT CK_BL_Thang CHECK (Thang BETWEEN 1 AND 12),
    CONSTRAINT CK_BL_TT    CHECK (TrangThai IN (N'Nhap',N'ChoDuyet',N'DaDuyet'))
);

-- 22. ChiTietBangLuong -------------------------------------------------------------------------------
CREATE TABLE dbo.ChiTietBangLuong (
    MaChiTietLuong   VARCHAR(30)   NOT NULL CONSTRAINT PK_CTBL PRIMARY KEY,
    MaBangLuong      VARCHAR(12)   NOT NULL CONSTRAINT FK_CTBL_BL REFERENCES dbo.BangLuong(MaBangLuong) ON DELETE CASCADE,
    MaNhanVien       VARCHAR(12)   NOT NULL CONSTRAINT FK_CTBL_NV REFERENCES dbo.NhanVien(MaNhanVien),
    TongGioCong      DECIMAL(7,2)  NOT NULL,
    GioPhuTroiQuyDoi DECIMAL(7,2)  NOT NULL CONSTRAINT DF_CTBL_GPT DEFAULT 0,
    LuongCoBan       DECIMAL(18,2) NOT NULL,   -- lương cơ bản theo công = lương QĐ x TongGioCong / 208
    PhuCap           DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_PC DEFAULT 0,
    TienPhuTroi      DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_PT DEFAULT 0,
    TienPhat         DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_PH DEFAULT 0,
    BHXH             DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_XH DEFAULT 0,
    BHYT             DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_YT DEFAULT 0,
    KhauTruKhac      DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTBL_KK DEFAULT 0,
    ThucLinh         DECIMAL(18,2) NOT NULL,
    CONSTRAINT UQ_CTBL UNIQUE (MaBangLuong, MaNhanVien),
    CONSTRAINT CK_CTBL_Tien CHECK (LuongCoBan >= 0 AND PhuCap >= 0 AND TienPhuTroi >= 0
                                   AND TienPhat >= 0 AND BHXH >= 0 AND BHYT >= 0 AND KhauTruKhac >= 0)
);
GO
-- =====================================================================
-- TRIGGER: ràng buộc nghiệp vụ liên bảng
-- =====================================================================
-- BR04: chỉ lập hồ sơ BHXH/BHYT cho hợp đồng DÀI HẠN của đúng nhân viên
CREATE TRIGGER dbo.trg_HoSoBaoHiem_DaiHan ON dbo.HoSoBaoHiem
AFTER INSERT, UPDATE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM inserted i
               JOIN dbo.HopDongLaoDong h ON h.MaHopDong = i.MaHopDong
               WHERE h.LoaiHopDong <> N'DaiHan' OR h.MaNhanVien <> i.MaNhanVien)
    BEGIN
        RAISERROR (N'BR04: chỉ lập hồ sơ BHXH, BHYT cho hợp đồng dài hạn của đúng nhân viên.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- BR17: quyết định lương đã duyệt không được sửa nội dung; chỉ lập quyết định thay thế
CREATE TRIGGER dbo.trg_QuyetDinhLuong_DaDuyet ON dbo.QuyetDinhLuong
AFTER UPDATE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN inserted i ON i.MaQuyetDinhLuong = d.MaQuyetDinhLuong
               WHERE d.TrangThaiDuyet IN (N'DaDuyet',N'DaThayThe')
                 AND (i.LuongCoBan <> d.LuongCoBan OR i.PhuCapLuong <> d.PhuCapLuong
                      OR i.PhuCapDocHai <> d.PhuCapDocHai OR i.NgayHieuLuc <> d.NgayHieuLuc))
    BEGIN
        RAISERROR (N'BR17: quyết định đã duyệt không được sửa; hãy lập quyết định thay thế.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- BR17 áp dụng tương tự cho quyết định khen thưởng đã duyệt
CREATE TRIGGER dbo.trg_QuyetDinhKhenThuong_DaDuyet ON dbo.QuyetDinhKhenThuong
AFTER UPDATE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN inserted i ON i.MaQuyetDinhKT = d.MaQuyetDinhKT
               WHERE d.TrangThaiDuyet = N'DaDuyet' AND (i.SoTien <> d.SoTien OR i.LyDo <> d.LyDo))
    BEGIN
        RAISERROR (N'BR17: quyết định khen thưởng đã duyệt không được sửa nội dung.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- =====================================================================
-- STORED PROCEDURE: tính lương tháng trong MỘT transaction (BR07, BR09, BR16)
-- Quy ước: công chuẩn 208 giờ/tháng (26 ngày x 8 giờ);
--   LuongCoBan(theo công) = Lương QĐ x Tổng giờ công / 208
--   TienPhuTroi = Giờ phụ trội quy đổi (1,5 x giờ) x Lương QĐ / 208
--   ThucLinh = LuongCoBan + PhuCap + TienPhuTroi - TienPhat - BHXH - BHYT - KhauTruKhac
--   (khen thưởng chi qua phiếu chi, không đưa vào bảng lương)
-- Chỉ tính cho nhân viên có dữ liệu chấm công trong tháng.
-- =====================================================================
CREATE PROCEDURE dbo.sp_TinhLuongThang
    @Thang INT, @Nam INT, @NguoiLap VARCHAR(12)
AS
BEGIN
    SET NOCOUNT ON; SET XACT_ABORT ON;
    DECLARE @DauThang DATE = DATEFROMPARTS(@Nam, @Thang, 1);
    DECLARE @CuoiThang DATE = EOMONTH(@DauThang);
    DECLARE @KyLuong CHAR(7) = FORMAT(@DauThang, 'yyyy-MM');
    DECLARE @MaBL VARCHAR(12) = 'BL' + FORMAT(@DauThang, 'yyyyMM');
    DECLARE @GioChuan DECIMAL(9,2) = 208;
    BEGIN TRY
        BEGIN TRAN;
        IF EXISTS (SELECT 1 FROM dbo.BangLuong WHERE Thang = @Thang AND Nam = @Nam)
            THROW 50001, N'Bảng lương của tháng này đã tồn tại.', 1;
        IF EXISTS (SELECT 1 FROM dbo.BangChamCong
                   WHERE NgayCong BETWEEN @DauThang AND @CuoiThang AND TrangThai <> N'DaXacNhan')
            THROW 50002, N'BR16: còn bản ghi chấm công chưa được xác nhận.', 1;
        IF EXISTS (SELECT 1 FROM (SELECT DISTINCT MaNhanVien FROM dbo.BangChamCong
                                  WHERE NgayCong BETWEEN @DauThang AND @CuoiThang) x
                   WHERE NOT EXISTS (SELECT 1 FROM dbo.QuyetDinhLuong q WHERE q.MaNhanVien = x.MaNhanVien
                                     AND q.TrangThaiDuyet = N'DaDuyet' AND q.NgayHieuLuc <= @CuoiThang)
                     AND NOT EXISTS (SELECT 1 FROM dbo.QuyetDinhTuyenDung t WHERE t.MaNhanVien = x.MaNhanVien
                                     AND t.TrangThaiDuyet = N'DaDuyet'))
            THROW 50003, N'BR16: có nhân viên chưa có quyết định lương/tuyển dụng đã duyệt.', 1;

        INSERT dbo.BangLuong (MaBangLuong, Thang, Nam, NgayLap, NguoiLap, TrangThai, TongLuong, TongKhauTru, TongThucLinh)
        VALUES (@MaBL, @Thang, @Nam, CAST(GETDATE() AS DATE), @NguoiLap, N'Nhap', 0, 0, 0);

        INSERT dbo.ChiTietBangLuong (MaChiTietLuong, MaBangLuong, MaNhanVien, TongGioCong, GioPhuTroiQuyDoi,
               LuongCoBan, PhuCap, TienPhuTroi, TienPhat, BHXH, BHYT, KhauTruKhac, ThucLinh)
        SELECT @MaBL + '-' + r.MaNhanVien, @MaBL, r.MaNhanVien, r.TongGioCong, r.GioPT,
               r.LuongCB, r.PhuCap, r.TienPT, r.Phat, r.BHXH, r.BHYT, r.KhauTruKhac,
               r.LuongCB + r.PhuCap + r.TienPT - r.Phat - r.BHXH - r.BHYT - r.KhauTruKhac
        FROM (
            SELECT n.MaNhanVien, n.TongGioCong,
                   ISNULL(pt.GioPT, 0) AS GioPT,
                   ROUND(ISNULL(ql.LuongCoBan, tv.LuongThuViec) * n.TongGioCong / @GioChuan, 0) AS LuongCB,
                   ISNULL(ql.PhuCapLuong, 0) + ISNULL(ql.PhuCapDocHai, 0) + ISNULL(cv.PhuCapChucVu, 0) AS PhuCap,
                   ROUND(ISNULL(pt.GioPT, 0) * ISNULL(ql.LuongCoBan, tv.LuongThuViec) / @GioChuan, 0) AS TienPT,
                   ISNULL(dc.Phat, 0) AS Phat, ISNULL(dc.Khac, 0) AS KhauTruKhac,
                   ROUND(ISNULL(bh.MucLuongDong, 0) * ISNULL(tl.TyLeBHXH_NV, 0), 0) AS BHXH,
                   ROUND(ISNULL(bh.MucLuongDong, 0) * ISNULL(tl.TyLeBHYT_NV, 0), 0) AS BHYT
            FROM (SELECT MaNhanVien, SUM(SoGioCong) AS TongGioCong FROM dbo.BangChamCong
                  WHERE NgayCong BETWEEN @DauThang AND @CuoiThang GROUP BY MaNhanVien) n
            OUTER APPLY (SELECT TOP 1 LuongCoBan, PhuCapLuong, PhuCapDocHai FROM dbo.QuyetDinhLuong q
                         WHERE q.MaNhanVien = n.MaNhanVien AND q.TrangThaiDuyet = N'DaDuyet' AND q.NgayHieuLuc <= @CuoiThang
                         ORDER BY q.NgayHieuLuc DESC) ql
            OUTER APPLY (SELECT TOP 1 LuongThuViec FROM dbo.QuyetDinhTuyenDung t
                         WHERE t.MaNhanVien = n.MaNhanVien AND t.TrangThaiDuyet = N'DaDuyet'
                         ORDER BY t.NgayQuyetDinh DESC) tv
            OUTER APPLY (SELECT TOP 1 PhuCapChucVu FROM dbo.QuyetDinhChucVu c
                         WHERE c.MaNhanVien = n.MaNhanVien AND c.TrangThaiDuyet = N'DaDuyet' AND c.NgayHieuLuc <= @CuoiThang
                         ORDER BY c.NgayHieuLuc DESC) cv
            OUTER APPLY (SELECT SUM(d.SoGio * 1.5) AS GioPT FROM dbo.ChiTietPhuTroi d
                         JOIN dbo.PhieuPhuTroi p ON p.MaPhieuPhuTroi = d.MaPhieuPhuTroi
                         WHERE d.MaNhanVien = n.MaNhanVien AND p.TrangThaiDuyet = N'DaDuyet'
                           AND p.NgayPhuTroi BETWEEN @DauThang AND @CuoiThang) pt
            OUTER APPLY (SELECT SUM(CASE WHEN LoaiDieuChinh = N'Phat' THEN SoTien END) AS Phat,
                                SUM(CASE WHEN LoaiDieuChinh = N'KhauTruKhac' THEN SoTien END) AS Khac
                         FROM dbo.DieuChinhLuong d
                         WHERE d.MaNhanVien = n.MaNhanVien AND d.KyLuong = @KyLuong AND d.TrangThai = N'ChoApDung') dc
            OUTER APPLY (SELECT TOP 1 h.MucLuongDong FROM dbo.HoSoBaoHiem h
                         JOIN dbo.HopDongLaoDong hd ON hd.MaHopDong = h.MaHopDong
                         WHERE h.MaNhanVien = n.MaNhanVien AND h.TrangThai = N'DangThamGia'
                           AND hd.LoaiHopDong = N'DaiHan' AND hd.TrangThai = N'HieuLuc') bh
            OUTER APPLY (SELECT TOP 1 TyLeBHXH_NV, TyLeBHYT_NV FROM dbo.TyLeBaoHiem
                         WHERE TuNgay <= @CuoiThang AND (DenNgay IS NULL OR DenNgay >= @CuoiThang)
                         ORDER BY TuNgay DESC) tl
        ) r;

        UPDATE bl SET TongLuong = s.TongLuong, TongKhauTru = s.TongKhauTru, TongThucLinh = s.TongThucLinh
        FROM dbo.BangLuong bl
        JOIN (SELECT MaBangLuong,
                     SUM(LuongCoBan + PhuCap + TienPhuTroi) AS TongLuong,
                     SUM(TienPhat + BHXH + BHYT + KhauTruKhac) AS TongKhauTru,
                     SUM(ThucLinh) AS TongThucLinh
              FROM dbo.ChiTietBangLuong WHERE MaBangLuong = @MaBL GROUP BY MaBangLuong) s
          ON s.MaBangLuong = bl.MaBangLuong;

        UPDATE dbo.DieuChinhLuong SET TrangThai = N'DaApDung' WHERE KyLuong = @KyLuong AND TrangThai = N'ChoApDung';
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRAN;
        THROW;
    END CATCH
END;
GO
