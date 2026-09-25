# 🏨 LAB 3 — HỆ THỐNG QUẢN LÝ KHÁCH SẠN

**Họ và tên:** Ngô Quốc Thiên Bảo
**Mã số sinh viên (MSSV):** 1250080015
**Lớp / Môn học:** Phân tích thiết kế hướng đối tượng (OOSD) — HUTECH
**Tên bài Lab:** Bài 3 — Hệ thống Quản lý Khách sạn

---

## 💻 1. Môi trường & Version

| Thành phần         | Công nghệ                               |
| ------------------ | --------------------------------------- |
| Ngôn ngữ lập trình | C#                                      |
| Framework          | .NET Framework 4.7.2                    |
| Loại ứng dụng      | Windows Forms App                       |
| Công cụ phát triển | Visual Studio 2022                      |
| Hệ quản trị CSDL   | SQL Server LocalDB / SQL Server Express |
| Kết nối CSDL       | ADO.NET                                 |
| Thư viện SQL       | `System.Data.SqlClient`                 |
| Hệ điều hành       | Windows 10 / Windows 11                 |

---

## 🚀 2. Nội dung đã thực hiện

Theo đúng mục tiêu của bài Lab, hệ thống đã hoàn thành các hạng mục sau.

### 2.1. Khảo sát nghiệp vụ

Phân tích các nghiệp vụ chính của hệ thống quản lý khách sạn:

* Đặt phòng.
* Nhận phòng.
* Quản lý phòng.
* Quản lý tiện nghi.
* Quản lý dịch vụ.
* Ghi nhận sử dụng dịch vụ.
* Lập phiếu đền bù.
* Trả phòng.
* Lập hóa đơn.
* Thanh toán.
* Thống kê doanh thu và tình hình sử dụng dịch vụ.

### 2.2. Phân tích và thiết kế hệ thống

Xác định các Actor chính:

* Nhân viên.
* Nhân viên lễ tân.
* Nhân viên phục vụ phòng.
* Nhân viên thanh toán.
* Quản lý.

Các biểu đồ đã thực hiện:

* Use Case Diagram.
* Use Case phân rã.
* Class Diagram.
* State Diagram.
* Sequence Diagram.
* Activity Diagram.

### 2.3. Thiết kế cơ sở dữ liệu

Xây dựng cơ sở dữ liệu:

```text
QuanLyKhachSan
```

Cơ sở dữ liệu gồm **17 bảng**, có đầy đủ:

* Khóa chính (`PRIMARY KEY`).
* Khóa ngoại (`FOREIGN KEY`).
* Ràng buộc `CHECK`.
* Ràng buộc `UNIQUE`.
* Các ràng buộc phục vụ kiểm soát nghiệp vụ.

Các nhóm dữ liệu chính:

* Phòng.
* Khu vực.
* Nhân viên.
* Khách hàng.
* Tiện nghi.
* Phiếu lắp đặt tiện nghi.
* Đặt phòng.
* Nhận phòng.
* Người lưu trú.
* Dịch vụ.
* Sử dụng dịch vụ.
* Đền bù.
* Hóa đơn.
* Thanh toán.
* Và các bảng dữ liệu liên quan.

### 2.4. Kiến trúc ứng dụng

Ứng dụng WinForms được tổ chức theo mô hình **3 lớp**:

```text
UI (Forms)
     ↓
Service (Business Logic)
     ↓
Data (Db.cs)
     ↓
SQL Server
```

Việc phân tách các tầng giúp hạn chế việc viết trực tiếp câu lệnh SQL trong các Form và giúp phần xử lý nghiệp vụ dễ quản lý, bảo trì hơn.

### 2.5. Giao diện

Hệ thống gồm **7 Form chính**:

| STT | Form               | Chức năng                  |
| --: | ------------------ | -------------------------- |
|   1 | `FrmMain`          | Giao diện chính            |
|   2 | `FrmDanhMuc`       | Quản lý danh mục           |
|   3 | `FrmPhongTienNghi` | Quản lý phòng và tiện nghi |
|   4 | `FrmDatPhong`      | Đặt và nhận phòng          |
|   5 | `FrmDichVu`        | Quản lý sử dụng dịch vụ    |
|   6 | `FrmTraPhong`      | Trả phòng và thanh toán    |
|   7 | `FrmThongKe`       | Thống kê                   |

### 2.6. Service xử lý nghiệp vụ

Hệ thống hiện có các Service chính:

* `DanhMucService`
* `PhongTienNghiService`
* `DatPhongService`
* `DichVuService`
* `TraPhongService`
* `ThongKeService`

Các Service chịu trách nhiệm xử lý nghiệp vụ và tương tác với tầng Data.

### 2.7. Transaction

Các nghiệp vụ cập nhật nhiều bảng được xử lý bằng `SqlTransaction` nhằm đảm bảo tính toàn vẹn dữ liệu.

Các nghiệp vụ có sử dụng transaction gồm:

* Lập phiếu đặt phòng.
* Ghi nhận sử dụng dịch vụ.
* Lập phiếu đền bù.
* Lập hóa đơn và thanh toán.
* Hoàn tất trả phòng.

Khi xảy ra lỗi trong quá trình xử lý, transaction sẽ thực hiện `Rollback` để tránh tình trạng dữ liệu được cập nhật không đầy đủ.

---

## 📂 3. Cấu trúc thư mục nộp bài

```text
LAB3/
├── README.md
├── QuanLyKhachSan.sln
│
├── Database/
│   └── QuanLyKhachSan.sql
│
└── QuanLyKhachSan/
    ├── QuanLyKhachSan.csproj
    ├── App.config
    ├── Program.cs
    │
    ├── Data/
    │   └── Db.cs
    │
    ├── Common/
    │   ├── KetQuaXuLy.cs
    │   ├── PhongDatItem.cs
    │   └── DenBuItem.cs
    │
    ├── Services/
    │   ├── DanhMucService.cs
    │   ├── PhongTienNghiService.cs
    │   ├── DatPhongService.cs
    │   ├── DichVuService.cs
    │   ├── TraPhongService.cs
    │   └── ThongKeService.cs
    │
    ├── Forms/
    │   ├── *.cs
    │   └── *.Designer.cs
    │
    └── Properties/
        └── AssemblyInfo.cs
```

### Thành phần chính

| Thành phần                    | Mô tả                             |
| ----------------------------- | --------------------------------- |
| `README.md`                   | Tài liệu hướng dẫn và mô tả dự án |
| `QuanLyKhachSan.sln`          | Solution Visual Studio            |
| `Database/QuanLyKhachSan.sql` | Script tạo CSDL và dữ liệu mẫu    |
| `Data/Db.cs`                  | Xử lý kết nối và truy cập CSDL    |
| `Services/`                   | Xử lý nghiệp vụ                   |
| `Forms/`                      | Giao diện Windows Forms           |
| `Common/`                     | Các lớp dùng chung                |

---

## 🛠️ 4. Hướng dẫn cài đặt và chạy lại

### Bước 1 — Khởi tạo cơ sở dữ liệu

Mở một trong các công cụ:

* SQL Server Management Studio (SSMS).
* SQL Server Object Explorer trong Visual Studio.

Kết nối tới:

```text
(localdb)\MSSQLLocalDB
```

hoặc SQL Server Express tương ứng trên máy.

Sau đó mở và chạy toàn bộ script:

```text
Database/QuanLyKhachSan.sql
```

Script sẽ thực hiện:

1. Tạo database `QuanLyKhachSan`.
2. Tạo các bảng dữ liệu.
3. Thiết lập khóa chính và khóa ngoại.
4. Thiết lập các ràng buộc `CHECK`, `UNIQUE`.
5. Thêm dữ liệu mẫu.

Dữ liệu mẫu bao gồm:

* 3 nhân viên.
* 2 khu vực.
* 3 phòng.
* 3 loại tiện nghi.
* 3 dịch vụ.
* 4 quy định đền bù.

---

### Bước 2 — Cấu hình kết nối

Mở file:

```text
QuanLyKhachSan/App.config
```

Kiểm tra chuỗi kết nối tại mục:

```text
QuanLyKhachSanDB
```

Nếu sử dụng LocalDB mặc định:

```text
(localdb)\MSSQLLocalDB
```

Nếu sử dụng SQL Server Express hoặc một SQL Server instance khác, thay đổi `Server`/`Data Source` trong connection string cho phù hợp với máy chạy chương trình.

---

### Bước 3 — Build và chạy chương trình

Mở:

```text
QuanLyKhachSan.sln
```

bằng **Visual Studio 2022**.

Sau đó:

```text
Ctrl + Shift + B
```

để Build Solution.

Nếu Build thành công, nhấn:

```text
F5
```

để chạy ứng dụng.

---

## ▶️ 5. Trình tự thao tác đề xuất

Sau khi chạy ứng dụng từ `FrmMain`, có thể kiểm tra hệ thống theo trình tự sau.

### 5.1. Danh mục

Vào **Danh mục** để:

* Thêm/sửa khu vực.
* Thêm/sửa nhân viên.
* Quản lý loại tiện nghi.
* Quản lý dịch vụ.
* Quản lý quy định đền bù.

Dữ liệu mẫu đã được cung cấp sẵn trong database.

### 5.2. Phòng - Tiện nghi

Thực hiện:

* Khai báo phòng.
* Quản lý tiện nghi.
* Lập phiếu lắp đặt tiện nghi cho phòng.

### 5.3. Đặt / Nhận phòng

Thực hiện:

1. Thêm thông tin khách hàng.
2. Lập phiếu đặt phòng.
3. Chọn phòng.
4. Nhập số người đăng ký.
5. Thực hiện nhận phòng.
6. Ghi nhận danh sách người lưu trú thực tế.

### 5.4. Sử dụng dịch vụ

Chọn phiếu lưu trú đang ở để ghi nhận dịch vụ.

Có thể kiểm tra chức năng cộng dồn bằng cách:

1. Ghi nhận một dịch vụ.
2. Ghi nhận lại cùng dịch vụ trong cùng ngày.
3. Kiểm tra số lượng và thành tiền được cộng dồn.

### 5.5. Trả phòng - Thanh toán

Thực hiện:

1. Lập phiếu đền bù nếu có tài sản hư hỏng hoặc mất mát.
2. Lập hóa đơn.
3. Kiểm tra tổng tiền phòng và dịch vụ.
4. Ghi nhận thanh toán.
5. Kiểm tra trạng thái hóa đơn.
6. Hoàn tất trả phòng.
7. Kiểm tra phòng được chuyển về trạng thái `Trống`.

### 5.6. Thống kê

Chọn khoảng thời gian cần tra cứu để xem:

* Doanh thu.
* Số lượng đặt phòng.
* Tình hình sử dụng dịch vụ.
* Các số liệu tổng hợp liên quan.

---

## 📊 6. Bảng kiểm thử quy tắc nghiệp vụ

|  STT | Điều kiện kiểm thử                             | Thao tác thực hiện  | Kết quả mong đợi                              |
| ---: | ---------------------------------------------- | ------------------- | --------------------------------------------- |
| TC01 | Phòng trống, số người ≤ sức chứa               | Lập phiếu đặt phòng | Thành công                                    |
| TC02 | Số người vượt quá sức chứa tối đa              | Lập phiếu đặt phòng | Từ chối                                       |
| TC03 | Phòng bị trùng lịch (Đã đặt / Đang ở)          | Lập phiếu đặt phòng | Từ chối, chặn chồng lấn                       |
| TC04 | Thiết bị đã lắp cho phòng khác cùng ngày       | Lập phiếu lắp đặt   | Từ chối do vi phạm `UNIQUE` thiết bị/ngày     |
| TC05 | Phiếu đang ở trạng thái `Đã đặt`               | Nhận phòng          | Chuyển sang trạng thái `Đang ở`               |
| TC06 | Số lượng người lưu trú vượt quá đăng ký        | Thêm người lưu trú  | Từ chối                                       |
| TC07 | Cùng một dịch vụ được sử dụng lần 2 trong ngày | Ghi nhận dịch vụ    | Cộng dồn số lượng và thành tiền               |
| TC08 | Phiếu không ở trạng thái `Đang ở`              | Ghi nhận dịch vụ    | Từ chối                                       |
| TC09 | Phát sinh tiện nghi hư hỏng hoặc mất mát       | Lập phiếu đền bù    | Lưu chi tiết và tính tổng tiền đền bù         |
| TC10 | Phiếu lưu trú có phát sinh dịch vụ             | Lập hóa đơn         | Tổng hợp chính xác tiền phòng + dịch vụ       |
| TC11 | Thanh toán một phần hóa đơn                    | Ghi nhận thanh toán | Hóa đơn giữ trạng thái `Chưa thanh toán`      |
| TC12 | Thanh toán đủ tổng tiền hóa đơn                | Ghi nhận thanh toán | Hóa đơn chuyển sang `Đã thanh toán`           |
| TC13 | Hóa đơn chưa thanh toán đủ tiền                | Hoàn tất trả phòng  | Từ chối                                       |
| TC14 | Hóa đơn đã thanh toán đủ tiền                  | Hoàn tất trả phòng  | Phiếu chuyển `Đã trả`, phòng chuyển `Trống`   |
| TC15 | Khoảng thời gian tra cứu hợp lệ                | Thống kê doanh thu  | Hiển thị số liệu tổng hợp và chi tiết dịch vụ |

---

## ⚠️ 7. Các lỗi thường gặp và cách khắc phục

| Lỗi phát sinh                       | Nguyên nhân                                                 | Cách khắc phục                                                      |
| ----------------------------------- | ----------------------------------------------------------- | ------------------------------------------------------------------- |
| Không kết nối được CSDL             | Chưa chạy script SQL hoặc connection string chưa đúng       | Chạy lại `QuanLyKhachSan.sql` và kiểm tra `App.config`              |
| Lỗi `UNIQUE` khi lập phiếu lắp đặt  | Thiết bị đã được lắp cho phòng khác trong cùng ngày         | Chọn ngày khác hoặc thiết bị khác                                   |
| ComboBox không hiển thị dữ liệu     | Gán sai thứ tự `DataSource`, `DisplayMember`, `ValueMember` | Gán `DataSource` trước, sau đó gán `DisplayMember` và `ValueMember` |
| Thanh toán vượt quá số tiền hóa đơn | Số tiền nhập lớn hơn số tiền còn phải thanh toán            | Nhập số tiền không vượt quá số tiền còn lại                         |

### Lưu ý đối với lỗi `UNIQUE`

Lỗi `UNIQUE` khi một thiết bị đã được lắp cho phòng khác trong cùng ngày là hành vi được thiết kế theo quy tắc nghiệp vụ.

Không xem đây là lỗi hệ thống nếu dữ liệu nhập vào thực sự vi phạm ràng buộc.

---

## 📝 8. Ghi chú về kiến trúc và xử lý nghiệp vụ

### 8.1. Tách biệt UI và nghiệp vụ

Toàn bộ mã nguồn tầng Service tuân thủ nguyên tắc:

> Không viết câu lệnh SQL trực tiếp bên trong các sự kiện của Form.

Luồng xử lý chính:

```text
Form
 ↓
Service
 ↓
Db
 ↓
SQL Server
```

Các câu lệnh truy vấn được đóng gói trong tầng Service và thực hiện truy cập dữ liệu thông qua `Data/Db.cs`.

### 8.2. Đảm bảo toàn vẹn dữ liệu

Các nghiệp vụ liên quan đến nhiều bảng được xử lý bằng `SqlTransaction`.

Ví dụ:

```text
Bắt đầu Transaction
        ↓
Thực hiện các thao tác CSDL
        ↓
Kiểm tra kết quả
   ↙            ↘
Thành công       Lỗi
   ↓              ↓
Commit          Rollback
```

Cơ chế này giúp hạn chế tình trạng dữ liệu được cập nhật không đầy đủ khi một bước trong nghiệp vụ xảy ra lỗi.

---

## 📸 9. Bằng chứng thực hiện

Thư mục nộp bài bao gồm các tài liệu phục vụ kiểm tra:

* Mã nguồn chương trình.
* Script cơ sở dữ liệu.
* README hướng dẫn cài đặt và sử dụng.
* Hình ảnh chụp giao diện thực tế của ứng dụng trên máy cá nhân.
* Sơ đồ cấu trúc cơ sở dữ liệu.
* File báo cáo Word (`.docx`) theo yêu cầu của bài Lab.

Các hình ảnh trong báo cáo được sử dụng làm bằng chứng cho quá trình thực hiện và kiểm thử hệ thống.

---

## ✅ 10. Tổng kết

Hệ thống **Quản lý Khách sạn** được xây dựng bằng **C# WinForms trên .NET Framework 4.7.2**, sử dụng **SQL Server** làm hệ quản trị cơ sở dữ liệu và **ADO.NET** để kết nối dữ liệu.

Hệ thống tập trung vào các nghiệp vụ chính:

```text
Quản lý danh mục
       ↓
Quản lý phòng - tiện nghi
       ↓
Đặt phòng
       ↓
Nhận phòng
       ↓
Sử dụng dịch vụ
       ↓
Đền bù
       ↓
Lập hóa đơn
       ↓
Thanh toán
       ↓
Trả phòng
       ↓
Thống kê
```

Ứng dụng được tổ chức theo mô hình **3 lớp**, có kiểm soát các quy tắc nghiệp vụ và sử dụng `SqlTransaction` cho các thao tác cập nhật dữ liệu liên quan đến nhiều bảng.

---

**Sinh viên thực hiện:** Ngô Quốc Thiên Bảo
**MSSV:** 1250080015
