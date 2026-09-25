LAB3 — Hệ thống quản lý khách sạn
Họ tên: (điền tên sinh viên)
MSSV: (điền MSSV)
Lớp / Môn học: Phân tích thiết kế hướng đối tượng (OOSD) — HUTECH
Tên bài Lab: Bài 3 — Hệ thống quản lý khách sạn
Môi trường / version:
Visual Studio 2022
.NET Framework 4.7.2 — Windows Forms App
SQL Server LocalDB / Express (ADO.NET, System.Data.SqlClient)
Hệ điều hành: Windows 10/11
1. Nội dung đã thực hiện

Theo đúng mục tiêu bài lab:

Khảo sát hiện trạng nghiệp vụ khách sạn: đặt/nhận/trả phòng, quản lý phòng - tiện nghi, sử dụng dịch vụ, đền bù, hóa đơn - thanh toán, thống kê.
Xác định Class, ID (khóa kỹ thuật MaKhuVuc, MaTienNghi, MaKhach, MaNV, MaThanhToan...), Actor (Nhân viên, NV lễ tân, NV phục vụ phòng, NV thanh toán, Quản lý), Use Case tổng quát và các Use Case phân rã.
Vẽ biểu đồ Use Case tổng quát, các Use Case phân rã (Quản lý phòng - tiện nghi, Đặt/nhận phòng, Trả phòng - thanh toán, Thống kê), biểu đồ lớp phân tích, biểu đồ trạng thái (PhieuDatPhong, HoaDon), các biểu đồ tuần tự theo từng chức năng, biểu đồ lớp chi tiết, biểu đồ hoạt động (Đặt phòng).
Thiết kế CSDL SQL Server QuanLyKhachSan gồm 17 bảng, đầy đủ khóa chính/khóa ngoại/ràng buộc CHECK/UNIQUE cho: phòng - tiện nghi, đặt phòng, dịch vụ, đền bù, hóa đơn, thanh toán.
Xây dựng ứng dụng WinForms theo kiến trúc 3 lớp: UI (Forms) -> Service (Business Logic) -> Data (Db.cs) -> SQL Server.
7 Form: FrmMain, FrmDanhMuc, FrmPhongTienNghi, FrmDatPhong, FrmDichVu, FrmTraPhong, FrmThongKe.
6 Service: DanhMucService, PhongTienNghiService, DatPhongService, DichVuService, TraPhongService, ThongKeService.
Các nghiệp vụ nhiều bảng (lập phiếu đặt phòng, ghi nhận dịch vụ, lập phiếu đền bù, thanh toán, trả phòng) đều dùng SqlTransaction để đảm bảo không dở dang.
Kiểm thử các quy tắc nghiệp vụ trọng tâm (xem bảng test case bên dưới).
2. Cấu trúc thư mục nộp bài
LAB3/
├── README.md                          (file này)
├── QuanLyKhachSan.sln                 (solution Visual Studio)
├── Database/
│   └── QuanLyKhachSan.sql             (script tạo CSDL + dữ liệu mẫu)
└── QuanLyKhachSan/                    (project WinForms)
    ├── QuanLyKhachSan.csproj
    ├── App.config
    ├── Program.cs
    ├── Data/Db.cs
    ├── Common/KetQuaXuLy.cs, PhongDatItem.cs, DenBuItem.cs
    ├── Services/*.cs      (6 service)
    ├── Forms/*.cs, *.Designer.cs      (7 form)
    └── Properties/AssemblyInfo.cs
3. Hướng dẫn cài đặt và chạy lại
Tạo CSDL: Mở SQL Server Management Studio (hoặc SQL Server Object Explorer trong Visual Studio), kết nối tới (localdb)\MSSQLLocalDB hoặc SQL Server Express, chạy toàn bộ file Database/QuanLyKhachSan.sql. Script sẽ tự tạo database QuanLyKhachSan, toàn bộ bảng, ràng buộc và dữ liệu mẫu (3 nhân viên, 2 khu vực, 3 phòng, 3 loại tiện nghi, 3 dịch vụ, 4 quy định đền bù).
Cấu hình kết nối: Nếu không dùng LocalDB mặc định, sửa connectionString trong QuanLyKhachSan/App.config (mục QuanLyKhachSanDB) cho đúng SQL Server đang dùng.
Mở project: Mở QuanLyKhachSan.sln bằng Visual Studio 2022 → chờ load xong → Build (Ctrl+Shift+B) → Start (F5).
Chạy thử: Màn hình FrmMain hiện ra với 7 nút chức năng tương ứng 7 Form. Thứ tự thao tác gợi ý để test đầy đủ luồng:
Danh mục → thêm khu vực/nhân viên/loại tiện nghi/dịch vụ/quy định đền bù (nếu cần bổ sung ngoài dữ liệu mẫu).
Phòng - Tiện nghi → thêm phòng, thêm tiện nghi, lập phiếu lắp đặt.
Đặt/Nhận phòng → thêm khách hàng, lập phiếu đặt phòng (chọn phòng + số người), nhận phòng, ghi nhận người lưu trú.
Sử dụng dịch vụ → ghi nhận dịch vụ cho phiếu đang ở (thử ghi 2 lần cùng dịch vụ/cùng ngày để kiểm tra cộng dồn).
Trả phòng - Thanh toán → (nếu có hư hỏng) lập phiếu đền bù → lập hóa đơn → thanh toán (thử chia nhiều lần) → hoàn tất trả phòng.
Thống kê → chọn khoảng ngày → xem tổng hợp và thống kê dịch vụ.
4. Kết quả
Build thành công trên Visual Studio 2022, target .NET Framework 4.7.2.
CSDL tạo đủ 17 bảng, insert dữ liệu mẫu thành công, các ràng buộc UNIQUE/CHECK hoạt động đúng khi test vi phạm.
Các luồng nghiệp vụ chính (đặt phòng, nhận phòng, ghi dịch vụ, đền bù, hóa đơn, thanh toán, trả phòng, thống kê) chạy đúng theo kịch bản test case.
(Bổ sung ảnh chụp giao diện thực tế và ảnh chụp CSDL từ máy cá nhân vào báo cáo Word — đây là bằng chứng bắt buộc theo yêu cầu nộp bài, mục 5.)
5. Bảng test case (tóm tắt — chi tiết xem báo cáo Word)
TC	Điều kiện	Thao tác	Kết quả mong đợi
TC01	Phòng trống, số người ≤ sức chứa	Lập phiếu đặt	Thành công
TC02	Số người vượt sức chứa	Lập phiếu đặt	Từ chối
TC03	Phòng trùng lịch (Đã đặt/Đang ở)	Lập phiếu đặt	Từ chối
TC04	Thiết bị đã lắp cho phòng khác cùng ngày	Lập phiếu lắp đặt	Từ chối (UNIQUE MaTienNghi+NgayLap)
TC05	Phiếu ở trạng thái Đã đặt	Nhận phòng	Chuyển sang Đang ở
TC06	Đã đủ số người đăng ký	Thêm người lưu trú	Từ chối
TC07	Cùng dịch vụ, cùng ngày, ghi lần 2	Ghi nhận dịch vụ	Cộng dồn số lượng/thành tiền
TC08	Phiếu không ở trạng thái Đang ở	Ghi nhận dịch vụ	Từ chối
TC09	Có tiện nghi hư hỏng/mất	Lập phiếu đền bù	Lưu chi tiết và tổng tiền
TC10	Phiếu đang ở có dịch vụ	Lập hóa đơn	Tiền phòng + tiền dịch vụ đúng
TC11	Thanh toán một phần	Ghi giao dịch thanh toán	Hóa đơn vẫn "Chưa thanh toán"
TC12	Thanh toán đủ	Ghi giao dịch thanh toán	Hóa đơn chuyển "Đã thanh toán"
TC13	Hóa đơn chưa thanh toán đủ	Hoàn tất trả phòng	Từ chối
TC14	Hóa đơn đã thanh toán đủ	Hoàn tất trả phòng	Phiếu "Đã trả", phòng "Trống"
TC15	Khoảng ngày hợp lệ	Thống kê	Có số liệu tổng hợp và theo dịch vụ
6. Lỗi gặp phải và cách khắc phục
Lỗi	Nguyên nhân	Cách khắc phục
Không kết nối được CSDL khi chạy	Chưa chạy script SQL hoặc sai connection string	Chạy lại Database/QuanLyKhachSan.sql; kiểm tra App.config đúng instance SQL Server đang dùng
Lỗi UNIQUE khi lập phiếu lắp đặt	Thiết bị đã được lắp cho phòng khác cùng ngày (đúng theo ràng buộc UQ_PhieuLapDat_ThietBi_Ngay)	Đây là hành vi đúng theo nghiệp vụ (BR04); chọn ngày khác hoặc thiết bị khác
ComboBox không hiển thị dữ liệu	Chưa gán đúng DisplayMember/ValueMember trước khi gán DataSource, hoặc gán ngược thứ tự	Luôn gán DataSource trước, sau đó DisplayMember/ValueMember (đã áp dụng nhất quán trong toàn bộ Form)
Thanh toán vượt số tiền hóa đơn	Nhập số tiền lớn hơn phần còn lại phải trả	Service ThanhToan đã kiểm tra da + tien > tong và từ chối; nhập lại số tiền hợp lệ
7. Ghi chú
Toàn bộ code Service tuân thủ nguyên tắc không viết SQL trực tiếp trong sự kiện của Form; mọi truy vấn nằm trong Service, truy cập dữ liệu qua Data/Db.cs.
Các nghiệp vụ cập nhật nhiều bảng (đặt phòng, ghi dịch vụ, đền bù, thanh toán) đều bọc trong SqlTransaction — rollback khi có lỗi.
File Word báo cáo kèm ảnh giao diện thực tế và ảnh chụp CSDL (bằng chứng bắt buộc) được đính kèm trong thư mục nộp bài (xem file .docx).