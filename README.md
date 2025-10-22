# Báo cáo Thực hành Lab 2: File và I/O Stream trong C#

Đây là project báo cáo cho bài thực hành Lab 2 môn Lập trình mạng căn bản tại trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM.

**Mục tiêu của bài thực hành:**
*   Làm quen và sử dụng thành thạo các lớp xử lý File và Stream trong C# (.NET Framework).
*   Thao tác với các file văn bản (.txt), file nhị phân.
*   Sử dụng Serializer (JSON) để đọc/ghi đối tượng.
*   Tương tác với cơ sở dữ liệu (SQLite).
*   Xây dựng ứng dụng Windows Forms hoàn chỉnh để giải quyết các bài toán cụ thể.

---

## Danh sách các bài tập

Project này bao gồm 7 bài tập, tất cả được xây dựng trên nền tảng Windows Forms.

| Bài | Chức năng chính | Ghi chú |
| :--- | :--- | :--- |
| **Bài 01** | **Đọc và Ghi File Text:** Đọc nội dung từ file `input1.txt`, chuyển thành chữ IN HOA và ghi ra `output1.txt`. | Sử dụng `StreamReader` và `StreamWriter`. |
| **Bài 02** | **Phân tích File:** Đọc một file `.txt` bất kỳ và hiển thị các thông tin chi tiết: tên file, kích thước, đường dẫn, số dòng, số từ, số ký tự. | Sử dụng `OpenFileDialog` và `FileInfo`. |
| **Bài 03** | **Tính toán biểu thức từ File:** Đọc các biểu thức toán học (ví dụ: `5 * (2 + 3)`) từ file `input3.txt`, tính toán kết quả và ghi ra `output3.txt`. | Xây dựng bộ giải biểu thức bằng thuật toán Shunting-yard (2 stack). |
| **Bài 04** | **Quản lý Sinh viên (JSON):** Nhập, lưu trữ, và hiển thị thông tin sinh viên. | Sử dụng `System.Text.Json` để serialize/deserialize danh sách đối tượng sinh viên. |
| **Bài 05** | **Quản lý Phòng vé:** Mô phỏng ứng dụng bán vé xem phim, cho phép chọn phim, phòng, ghế, thanh toán và xuất báo cáo doanh thu. | Sử dụng `ProgressBar` để hiển thị tiến trình. |
| **Bài 06** | **Hôm nay ăn gì? (SQLite):** Ứng dụng cho phép thêm món ăn và chọn ngẫu nhiên một món từ CSDL. | Tương tác với **SQLite**, xử lý và sao chép file hình ảnh. |
| **Bài 07** | **Trình duyệt File:** Xây dựng một trình duyệt file đơn giản, hiển thị cây thư mục và cho phép xem trước nội dung file text/ảnh. | Sử dụng `TreeView` với kỹ thuật "tải lười" (lazy loading) để tối ưu hiệu năng. |

*Ghi chú: Hình ảnh minh họa chi tiết và các trường hợp kiểm thử (test cases) cho từng bài được trình bày đầy đủ trong file báo cáo Word/PDF đính kèm.*

---

## Công nghệ sử dụng

*   **Ngôn ngữ:** C#
*   **Nền tảng:** .NET Framework, Windows Forms
*   **Cơ sở dữ liệu:** SQLite (cho Bài 6)
*   **Thư viện:**
    *   `System.IO` cho các thao tác file và stream.
    *   `System.Text.Json` để xử lý JSON.
    *   `System.Data.SQLite` để kết nối và truy vấn CSDL.
*   **IDE:** Visual Studio 2022

---

## Hướng dẫn cài đặt và sử dụng

### Yêu cầu
*   Visual Studio 2019 trở lên (đã cài đặt .NET Desktop Development workload).
*   .NET Framework 4.7.2 hoặc mới hơn.

### Các bước chạy Project
1.  **Clone repository:**
    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    ```
2.  Mở project bằng cách nhấp đúp vào file `.sln` (ví dụ: `NT106_Lab2_Project.sln`).
3.  **Restore NuGet Packages:** Visual Studio sẽ tự động restore các package cần thiết (như `System.Data.SQLite`). Nếu không, bạn có thể chuột phải vào Solution trong Solution Explorer và chọn `Restore NuGet Packages`.
4.  **Quan trọng - Thiết lập file dữ liệu:**
    *   Đảm bảo các file input (`input1.txt`, `input3.txt`, `input4.txt`, `input5.txt`, `MonAn.db`) đã được thiết lập thuộc tính **Copy to Output Directory** thành **Copy if newer** trong Visual Studio.
5.  **Chạy chương trình:**
    *   Để chạy từng bài riêng lẻ, bạn cần mở file `Program.cs` và thay đổi Form khởi động.
    *   Ví dụ, để chạy **Bài 7**, hãy sửa dòng `Application.Run(...)` thành:
        ```csharp
        // Application.Run(new Lab02_Bai01());
        Application.Run(new Lab02_Bai07()); 
        ```
    *   Nhấn `F5` hoặc nút `Start` để build và chạy.

---

## Thông tin tác giả


*   **Họ và tên:**Quách Trọng Hải Quân
*   **MSSV:** 23521269
*   **Lớp:** NT106.Q14.1
