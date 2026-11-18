# Buổi 02 – Danh sách

Họ tên: Nguyễn Viết Đạt · MSV: 12425012

## Bài đã làm
Bài 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18

## Cách chạy
```bash
dotnet run --project Buoi02_DanhSach
```
Nếu muốn chạy từng abif theo yêu cầu 
```bash
dotnet run --project Buoi02_DanhSach menu
```

## Kết quả chạy
```
 Bài 1: Chèn phần tử vào mảng
Nhập số phần tử n: 5
Nhập a[0]: 1
Nhập a[1]: 2
Nhập a[2]: 3
Nhập a[3]: 4
Nhập a[4]: 5

Danh sách vừa nhập:
1 2 3 4 5

Nhập giá trị x cần chèn: 9
Nhập vị trí k cần chèn (0 đến 5): 3
Danh sách sau khi chèn:
1 2 3 9 4 5

 Bài 2: Quản lý nhân viên
Tổng thực lương toàn công ty: 5,000,000 VNĐ
Nhân viên có thực lĩnh thấp nhất (1,600,000 VNĐ):
  - Nguyễn Phong Hòa (Mã: NV01, Phòng: IT, Lương thực lĩnh: 1,600,000)
Số lượng nhân viên có thưởng >= 1.200.000 VNĐ: 0
Danh sách nhân viên sau khi sắp xếp (Phòng ban ASC, Mã NV DESC):
  - Phòng: IT | Mã NV: NV03 | Tên NV: Lê Thành Long
  - Phòng: IT | Mã NV: NV02 | Tên NV: Nguyễn Minh Hiển
  - Phòng: IT | Mã NV: NV01 | Tên NV: Nguyễn Phong Hòa
Danh sách sau khi tăng 5% lương cơ bản:
  - Mã NV: NV01 | Tên NV: Nguyễn Phong Hòa | Lương CĐ mới: 1,470,000 | Thực lĩnh mới: 1,670,000
  - Mã NV: NV02 | Tên NV: Nguyễn Minh Hiển | Lương CĐ mới: 1,575,000 | Thực lĩnh mới: 1,775,000
  - Mã NV: NV03 | Tên NV: Lê Thành Long | Lương CĐ mới: 1,575,000 | Thực lĩnh mới: 1,775,000

 Bài 3: Xử lý ma trận 2 chiều
Ma trận 3x3:
   2   5   1
   4   8   9
   7   3  12
Tổng các phần tử trong ma trận: 51
Số dương nhỏ nhất trong ma trận: 1
Tổng các phần tử trên đường chéo phụ: 16
Đường chéo chính có tăng dần không: Có

 Bài 4: Tìm kiếm và xóa phần tử trên mảng
Mảng ban đầu: -3 5 2 7 5 10 -1
Số phần tử bằng 5: 2
Số dương nhỏ nhất trong mảng: 2
Mảng sau khi xoá phần tử 5 đầu tiên: -3 2 7 5 10 -1

 Bài 5: Thống kê số nguyên
Mảng a: -4 2 3 5 0 7 12 -8
Phần tử lớn nhất: 12
Tổng các phần tử: 17
Số phần tử là số nguyên tố: 4
Số lượng số dương: 5 | Số lượng số âm: 2
Số lượng phần tử bằng 3: 1
Số dương nhỏ nhất trong mảng: 2

 Bài 7: Quản lý nhiệt độ
Dữ liệu nhiệt độ 7 ngày: 28.5°C, 30°C, 32.2°C, 29.8°C, 27°C, 31.5°C, 33°C
- Ngày nhiệt độ cao nhất: Ngày 7 (33°C)
- Ngày nhiệt độ thấp nhất: Ngày 5 (27°C)
- Nhiệt độ trung bình: 30.29°C

 Bài 8: Thống kê tần suất từ
Văn bản: "Học cấu trúc dữ liệu và giải thuật, học lập trình C# rất thú vị!"
Tần suất xuất hiện của từng từ:
  - học            : 2 lần
  - c              : 1 lần
  - cấu            : 1 lần
  - dữ             : 1 lần
  - giải           : 1 lần
  - lập            : 1 lần
  - liệu           : 1 lần
  - rất            : 1 lần
  - thú            : 1 lần
  - thuật          : 1 lần
  - trình          : 1 lần
  - trúc           : 1 lần
  - và             : 1 lần
  - vị             : 1 lần

 Bài 9: Xử lý số nguyên nâng cao
Dãy số: 2 6 7 10 13 28 15 4 29
- Các số nguyên tố: 2, 7, 13, 29
- Các số chẵn:      2, 6, 10, 28, 4
- Các số hoàn hảo:  6, 28

 Bài 10: Ma trận xoắn ốc
Ma trận gốc 4x4:
   1   2   3   4
   5   6   7   8
   9  10  11  12
  13  14  15  16
Thứ tự duyệt xoắn ốc: 1 -> 2 -> 3 -> 4 -> 8 -> 12 -> 16 -> 15 -> 14 -> 13 -> 9 -> 5 -> 6 -> 7 -> 11
-> 10

 Bài 11: Kiểm tra ma trận đặc biệt
Ma trận m1 -> Đơn vị: False, Đối xứng: False
Ma trận m2 -> Đơn vị: False, Đối xứng: True

 Bài 12: Trò chơi Minesweeper
Bảng Minesweeper 5x5 (5 mìn):
 *  2  2  *  1
 1  2  *  2  1
 0  2  2  3  1
 0  1  *  2  *
 0  1  1  2  1

 Bài 13: Đảo ngược DSLK đơn
Ban đầu:   10 -> 20 -> 30 -> 40 -> 50 -> null
Đảo ngược: 50 -> 40 -> 30 -> 20 -> 10 -> null

 Bài 14: Gộp hai DSLK đã sắp xếp
Danh sách 1: 1 -> 4 -> 7 -> 10 -> null
Danh sách 2: 2 -> 3 -> 6 -> 8 -> 12 -> null
Sau khi gộp: 1 -> 2 -> 3 -> 4 -> 6 -> 7 -> 8 -> 10 -> 12 -> null

 Bài 15: Phát hiện chu trình (Floyd)
Danh sách 1 (2 -> 3 -> 4 -> 5 -> 6 -> 2 [vòng]) có chu trình: True
Danh sách 2 (1 -> 2 -> 3 -> 4 -> null) có chu trình: False

 Bài 16: Lịch sử duyệt web (DSLK kép)
Trang khởi tạo: google.com
Truy cập trang mới: Youtube.com
Truy cập trang mới: utehy.edu.vn

[Mô phỏng điều hướng]
Thao tác Back -> Youtube.com
Thao tác Back -> google.com
Thao tác Forward -> Youtube.com
Trang hiện tại kết thúc: [Youtube.com]

 Bài 17: Playlist nhạc (DSLK kép)
Khởi tạo playlist:
  1. Em của ngày hôm qua - Sơn Tùng M-TP
  2. Tháng 4 là lời nói dối của em - Hà Anh Tuấn
  3. Nơi tình yêu bắt đầu - Bùi Anh Tuấn

[Mô phỏng phát nhạc]
Đang phát: Em của ngày hôm qua - Sơn Tùng M-TP
Next bài hát -> Đang phát: Tháng 4 là lời nói dối của em - Hà Anh Tuấn
Thêm bài:Mơ hồ
Xóa bài đang phát (Tháng 4 là lời nói dối của em - Hà Anh Tuấn)
Đang phát bài thay thế: Nơi tình yêu bắt đầu - Bùi Anh Tuấn

 Bài 18: Hệ thống đặt hàng (DSLK kép)
Đơn hàng [DH_12425012] - Khởi tạo trạng thái:  Chờ xử lý

[Mô phỏng chuyển đổi trạng thái đơn hàng]
Chuyển bước tiếp theo:  Đang giao
Chuyển bước tiếp theo:  Hoàn thành
Lùi lại bước trước:  Đang giao
