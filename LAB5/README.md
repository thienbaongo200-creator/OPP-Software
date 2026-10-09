# Bài tập 6 – Quản lý công ty du lịch

## Thông tin sinh viên

- **Họ và tên:** Ngô Quốc Thiên Bảo
- **MSSV:** 1250080015

## Tài liệu và mã nguồn

- Đề bài: [`Bai_6_Quan_ly_cong_ty_du_lich.pdf`](./Bai_6_Quan_ly_cong_ty_du_lich.pdf)
- Project hiện có: [`QuanLyCongTyDuLich_Lab5`](./QuanLyCongTyDuLich_Lab5/)
- Hướng dẫn chi tiết của project: [`README_HUONG_DAN.md`](./QuanLyCongTyDuLich_Lab5/README_HUONG_DAN.md)


## Cách thực hiện

### 1. Đọc và phân tích đề

1. Mở file PDF và ghi lại các yêu cầu về chức năng, dữ liệu, giao diện, sơ đồ và hồ sơ cần nộp.
2. Đánh dấu yêu cầu nào đã có trong project hiện tại, yêu cầu nào còn thiếu hoặc khác với đề.
3. Lập bảng đối chiếu yêu cầu với nơi triển khai: database, form, service, sơ đồ UML và ca kiểm thử.

### 2. Chuẩn bị cơ sở dữ liệu

1. Cài/mở SQL Server và kết nối với instance đang dùng (mặc định trong hướng dẫn project là `(localdb)\MSSQLLocalDB`).
2. Mở `QuanLyCongTyDuLich_Lab5/Database/QuanLyCongTyDuLich.sql` bằng SSMS và kiểm tra database đích trước khi chạy.
3. Chạy script để tạo cấu trúc và dữ liệu mẫu.
4. Chạy `QuanLyCongTyDuLich_Lab5/Tests/KiemTraDuLieu.sql` để kiểm tra các bảng và dữ liệu.
5. Nếu dùng SQL Server instance khác, cập nhật connection string trong `QuanLyCongTyDuLich_Lab5/App.config`.

### 3. Mở và chạy ứng dụng

1. Mở `QuanLyCongTyDuLich_Lab5/QuanLyCongTyDuLich.sln` bằng Visual Studio 2022.
2. Cài workload **.NET desktop development** và .NET Framework 4.7.2 targeting pack nếu Visual Studio yêu cầu.
3. Chọn project `QuanLyCongTyDuLich` làm Startup Project rồi chạy **Build Solution**.
4. Chạy ứng dụng bằng `F5`; ở form chính, bấm **Kiểm tra kết nối CSDL**.
5. Nếu kết nối thất bại, kiểm tra SQL Server, tên database và connection string trong `App.config`.

### 4. Kiểm tra chức năng

Thử các luồng nghiệp vụ qua các form, kiểm tra thông báo và đối chiếu kết quả trực tiếp trong database:

- Tạo chuyến khách lẻ, sau đó kiểm tra bản ghi trong bảng `ChuyenLe`.
- Hủy phiếu đăng ký đoàn theo kịch bản trong hướng dẫn; kiểm tra trạng thái, tiền cọc và phân công hướng dẫn viên.
- Thử thêm/sửa dữ liệu danh mục, tour, đăng ký, phân công, thanh toán và thống kê theo phạm vi yêu cầu của đề.

Các kịch bản kiểm thử chi tiết và câu SQL đối chứng có trong [`README_HUONG_DAN.md`](./QuanLyCongTyDuLich_Lab5/README_HUONG_DAN.md). Nên dùng database thử mới cho các ca làm thay đổi trạng thái hoặc dữ liệu.

### 5. Hoàn thiện sơ đồ và báo cáo

Project có 6 sơ đồ PlantUML trong `QuanLyCongTyDuLich_Lab5/UML/`: hai Use Case phân rã, hai Activity và hai Sequence. Mở các file `.puml` bằng công cụ hỗ trợ PlantUML để xem hoặc xuất ảnh. Đối chiếu lại tên tác nhân, luồng và quy tắc nghiệp vụ với PDF trước khi đưa vào báo cáo.

Khi báo cáo, trình bày yêu cầu, thiết kế, cách chạy, kết quả kiểm thử và ảnh minh chứng phù hợp với đề. Chỉ ghi nhận những chức năng đã chạy thử thực tế; nêu rõ phần nào còn thiếu hoặc chưa kiểm chứng.
