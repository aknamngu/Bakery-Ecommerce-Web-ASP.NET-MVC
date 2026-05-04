Sweet & Savory Bakery - Website Bán Bánh 
Đây là website thương mại điện tử dành cho tiệm bánh "Sweet & Savory", được xây dựng bằng ASP.NET MVC 5 và Entity Framework Code-First.

🥐 Các tính năng chính
Danh mục & Sản phẩm: Hiển thị catalogue bánh, chi tiết từng loại sản phẩm.

Giỏ hàng: Cho phép khách hàng thêm, xóa bánh và áp dụng mã giảm giá (Voucher).

Đặt hàng: Quy trình Checkout và quản lý đơn hàng cho khách.

Admin Panel: Trang quản trị dành riêng cho chủ tiệm để quản lý bánh, banner, khuyến mãi và đơn hàng.

Gửi Mail tự động: Sử dụng Hangfire để lên lịch gửi mail thông báo khuyến mãi cho khách hàng.

🛠 Công nghệ sử dụng
ASP.NET MVC 5 (.NET Framework 4.8)

SQL Server (Entity Framework Code-First)

Hangfire (Quản lý các tác vụ chạy ngầm)

Giao diện: Bootstrap 5, Razor View

📝Để chạy dự án trên máy cá nhân, các bạn làm theo các bước sau:

Tải code: Nhấn Clone hoặc Download ZIP về máy.

Cấu hình Database:

Mở file Web.config.

Kiểm tra dòng connectionStrings, đảm bảo Data Source trỏ đúng vào SQL Server máy bạn (thường là (localdb)\MSSQLLocalDB).

Tạo Database:

Mở Package Manager Console trong Visual Studio.

Gõ lệnh: Update-Database rồi nhấn Enter. Lệnh này sẽ tự tạo database BakeryDb và các bảng dữ liệu mẫu.

Chạy Web: Nhấn nút Start (F5) để bắt đầu.
