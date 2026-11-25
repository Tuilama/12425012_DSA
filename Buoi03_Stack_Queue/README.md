# Buổi 03 – Stack và Queue

Họ tên: Nguyễn Viết Đạt · MSV: 12425012

## Bài đã làm
Chương 5: bài 1, 2, 3, 4, 5, 6.
BT Bổ sung: bài 4, 5, 6, 7, 8, 9, 10, 11.

## Cách chạy
```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy
```
Bài 1
Nhập biểu thức: 3
Chuỗi hợp lệ
Bài 2

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web1
Đang truy cập: web1

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web3
Đang truy cập: web3

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web2
Đang truy cập: web2

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 web3 [web2]
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 2
Bạn chọn: Back
Đang truy cập: web3

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 [web3] web2
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 3
Bạn chọn: Forward
Đang truy cập: web2

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 0
Bài 3

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 1
Nhập tên hàm: jqk
Nhập tham số: c=2
Gọi hàm jqk từ hàm Main

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 1
Nhập tên hàm: xyz
Nhập tham số: b=3
Gọi hàm xyz từ hàm jqk

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 3
Call Stack:
  - xyz (b=3)     - jqk
  - jqk (c=2)     - Main
  - Main ()     - hdh

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 2
Hàm xyz kết thúc, trả về hàm jqk

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 3
Call Stack:
  - jqk (c=2)     - Main
  - Main ()     - hdh

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 0
Bài 4

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên yêu cầu: in tai lieu
Nhập số trang: 50
Yêu cầu in tai lieu với 50 trang đã được thêm vào hàng đợi

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: in giao trinh
Chọn: 300

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu:
  - in tai lieu (50 trang)

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên yêu cầu: in SGK
Nhập số trang: 100
Yêu cầu in SGK với 100 trang đã được thêm vào hàng đợi

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu:
  - in tai lieu (50 trang)
  - in SGK (100 trang)

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 2
Yêu cầu in tai lieu với 50 trang đã được xử lý

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 0
Bài 5

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập nội dung: Bai tap
Gói tin 1 với nội dung "Bai tap" đã được thêm vào hàng đợi

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập nội dung: Toan
Gói tin 2 với nội dung "Toan" đã được thêm vào hàng đợi

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi gói tin:
  - Gói tin 1: "Bai tap"
  - Gói tin 2: "Toan"

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 2
Gói tin 1 với nội dung "Bai tap" đã được xử lý

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 0
Bài 6

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên khách hàng: Dat
Nhập loại dịch vụ: Ngu
Khách hàng Dat đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên khách hàng: Long
Nhập loại dịch vụ: Masage
Khách hàng Long đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên khách hàng: Hien
Nhập loại dịch vụ: Hat
Khách hàng Hien đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 3
Số khách đang chờ: 3
Khách tiếp theo: Dat
Hàng đợi khách hàng:
  - 1. Dat (16:08:10) - Ngu
  - 2. Long (16:08:19) - Masage
  - 3. Hien (16:08:29) - Hat

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 2
Khách hàng Dat với loại dịch vụ Ngu đã được xử lý
Đã chờ 23 giây

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 0
Bài BS 4

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: youtube.com
Đang truy cập: youtube.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: facebook.com
Đang truy cập: facebook.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: hyute.edu
Đang truy cập: hyute.edu

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 4
Trang hiện tại: hyute.edu

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 2
Quay lại: facebook.com

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 3
Tiến lên: hyute.edu

MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 0
Bài BS 5
Nhập chuỗi chỉ gồm '(' và ')': ()()())()((()
Xâu sai
Bài BS 6

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 1
Nhập tên tài liệu: Toan
Yêu cầu in "Toan" đã được thêm vào hàng đợi

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 1
Nhập tên tài liệu: Van
Yêu cầu in "Van" đã được thêm vào hàng đợi

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 1
Nhập tên tài liệu: Anh
Yêu cầu in "Anh" đã được thêm vào hàng đợi

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu in:
  - Toan
  - Van
  - Anh

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 2
Đã in xong tài liệu "Toan"

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 0
Bài BS 7

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 1
Nhập gói dữ liệu: t1
Đã gửi gói dữ liệu: t1

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 1
Nhập gói dữ liệu: t2
Đã gửi gói dữ liệu: t2

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 3
Các gói dữ liệu trong hàng đợi:
  - t1
  - t2

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 2
Đã nhận gói dữ liệu: t1

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 0
Bài BS 8

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: 1
Khách hàng 1 đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: 2
Khách hàng 2 đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: 3
Khách hàng 3 đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 3
Danh sách khách hàng chờ:
  - 1
  - 2
  - 3

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 2
Đang phục vụ khách hàng: 1

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 0

Bài BS 9
Nhập biểu thức hậu tố (cách nhau bởi dấu cách): 5 6 9 * +
Giá trị biểu thức hậu tố là: 59
Bài BS 10
Nhập biểu thức: +4 * 8
Chuỗi không hợp lệ
Bài BS 11
Nhập biểu thức trung tố: (5 + 4) * 3 - 2 / 3
Biểu thức hậu tố: 5 4 + 3 * 2 3 / -
Kết quả: 26.333334