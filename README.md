#Mẫu số 1 - Abstract Factory
<span style="color:#00FFFF;">
- Dùng khi: Cần tạo nhóm đối tượng liên quan và muốn hoán đổi cả họ (family) dễ dàng (UI WinForms vs WPF; SQL vs MySQL).
- Giải quyết: Tránh if/else khổng lồ chọn từng lớp cụ thể; gom cấu hình theo “họ”.
- Ưu điểm: Thay đổi “họ” qua một chỗ; đảm bảo các đối tượng hợp nhau. 
- Nhược điểm: Nhiều lớp, hơi nặng lúc khởi tạo.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="493" height="197" alt="image" src="https://github.com/user-attachments/assets/67541575-fc9f-47dd-b1d8-f8d4bc3be8d6" />
- Real code
  + Kết quả:
    <img width="470" height="155" alt="image" src="https://github.com/user-attachments/assets/ebd8b7e8-082d-4401-b756-429be5b7c617" />


#Mẫu số 2 - Singleton
<span style="color:#00FFFF;">
- Dùng khi: Một thực thể duy nhất trong toàn hệ: cấu hình, bộ nhớ đệm, logger.
- Giải quyết: Đảm bảo toàn app dùng cùng một thể hiện.
- Ưu điểm: Truy cập tiện. 
- Nhược điểm: Dễ bị lạm dụng → che giấu phụ thuộc, khó unit test (nên kết hợp DI).
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="472" height="183" alt="image" src="https://github.com/user-attachments/assets/9d0f940b-f732-47d7-96a7-3ffa710271f1" />
- Real code
  + Kết quả:
    <img width="470" height="425" alt="image" src="https://github.com/user-attachments/assets/d0b6149a-f536-42dd-9f6c-00c82925910c" />


#Mẫu số 3 - Builder
<span style="color:#00FFFF;">
- Dùng khi: Đối tượng phức tạp, nhiều bước/tùy chọn; thứ tự xây dựng quan trọng.
- Giải quyết: Tách “quy trình lắp ráp” khỏi “cấu trúc thành phẩm”.
- Ưu điểm: Code dựng rõ ràng, có thể tái dùng kịch bản. 
- Nhược điểm: Nhiều lớp builder.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="528" height="242" alt="image" src="https://github.com/user-attachments/assets/2c73a927-6a4b-4cda-a357-b8f68b26bbd4" />
- Real code
  + Kết quả:
    <img width="527" height="498" alt="image" src="https://github.com/user-attachments/assets/2c76fd5b-582d-4426-af00-a6f5d79a34e4" />

    

#Mẫu số 4 - FactoryMethod
<span style="color:#00FFFF;">
- Dùng khi: Lớp cha biết tạo cái gì, nhưng không biết lớp con cụ thể; cần mở rộng qua kế thừa.
- Giải quyết: Hoãn việc chọn lớp cụ thể xuống lớp con.
- Ưu điểm: Dễ mở rộng loại sản phẩm. 
- Nhược điểm: Tăng số lớp con.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="534" height="145" alt="image" src="https://github.com/user-attachments/assets/82bdf286-ac0a-4e8f-ab16-7873bac78534" />
- Real code
  + Kết quả:
    <img width="471" height="348" alt="image" src="https://github.com/user-attachments/assets/d099aa34-b7fe-4c5f-ab55-46dbbf0a7931" />

#Mẫu số 5 - Prototype
<span style="color:#00FFFF;">
- Dùng khi: Cần nhân bản đối tượng tốn kém tạo mới (nhiều cấu hình) hoặc muốn clone trạng thái mẫu.
- Giải quyết: Clone() (nông/sâu) từ bản mẫu.
- Ưu điểm: Tạo nhanh, không phụ thuộc constructor dài. 
- Nhược điểm: Phải xử lý clone sâu/quan hệ tham chiếu.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="479" height="164" alt="image" src="https://github.com/user-attachments/assets/9e4abfc6-fd8d-4577-b36a-ce82f5ce8758" />
- Real code
  + Kết quả:
    <img width="473" height="195" alt="image" src="https://github.com/user-attachments/assets/a8062b1b-b5fd-49bf-92db-02735e877721" />


#Mẫu số 6 - Adapter
<span style="color:#00FFFF;">
- Dùng khi: Tích hợp API cũ/khác chuẩn với hệ thống hiện tại.
- Giải quyết: Bọc lớp lạ thành interface quen thuộc.
- Ưu điểm: Tận dụng code cũ, giảm sửa lõi. 
- Nhược điểm: Có thể che giấu thiết kế xấu phía sau.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="479" height="145" alt="image" src="https://github.com/user-attachments/assets/c6c52a1b-163d-4ffc-bf46-87c6770554e5" />
- Real code
  + Kết quả:
    <img width="470" height="497" alt="image" src="https://github.com/user-attachments/assets/40358162-0a9c-44bd-9c61-5a0d4cb75526" />


#Mẫu số 7 - Bridge
<span style="color:#00FFFF;">
- Dùng khi: Có 2 chiều thay đổi độc lập (Abstraction vs Implementation).
- Giải quyết: Tách hệ phân cấp thành 2 lớp, kết hợp qua composition.
- Ưu điểm: Mỗi chiều tiến hóa độc lập.
- Nhược điểm: Phức tạp hóa kiến trúc ban đầu.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="471" height="159" alt="image" src="https://github.com/user-attachments/assets/c49204fa-86ec-4191-be16-9c2fd2ff102c" />
- Real code
  + Kết quả:
    <img width="468" height="364" alt="image" src="https://github.com/user-attachments/assets/2843e79e-0735-4ad0-bebd-2992eda15342" />

    

#Mẫu số 8 - Composite
<span style="color:#00FFFF;">
- Dùng khi: Cần biểu diễn cấu trúc cây (phần-toàn thể) và thao tác đồng nhất trên lá & nhóm.
- Giải quyết: Component (chung), Leaf, Composite (chứa con).
- Ưu điểm: Duyệt và tính toán đơn giản. 
- Nhược điểm: Quản trị vòng đời con phức tạp.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="474" height="253" alt="image" src="https://github.com/user-attachments/assets/eb1c792c-5bad-4c88-ac26-d1b0ed34d363" />
- Real code
  + Kết quả:
  <img width="469" height="235" alt="image" src="https://github.com/user-attachments/assets/532e8b6e-f3c6-431e-a41b-de3140dfd2fb" />
    

#Mẫu số 9 - Decorator
<span style="color:#00FFFF;">
- Dùng khi: Muốn bổ sung hành vi động cho đối tượng mà không tạo quá nhiều lớp con.
- Giải quyết: Bọc lớp gốc bằng các “áo” (decorator) xếp chồng.
- Ưu điểm: Linh hoạt, kết hợp tự do. 
- Nhược điểm: Xâu chuỗi nhiều lớp khó debug.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="478" height="165" alt="image" src="https://github.com/user-attachments/assets/bb97c801-a1ff-4368-8a54-12dd43c611ac" />
- Real code
  + Kết quả:
  <img width="516" height="520" alt="image" src="https://github.com/user-attachments/assets/edb379f9-cf45-4bc5-8486-d4531b6f153b" />



#Mẫu số 10 - Decorator
<span style="color:#00FFFF;">
- Dùng khi: Hệ con phức tạp, client chỉ cần cửa đơn giản.
- Giải quyết: Lớp Facade gom nhiều subsystem (Bank/Loan/Credit) thành API gọn.
- Ưu điểm: Dễ dùng, giảm coupling. 
- Nhược điểm: Có thể che giấu chi tiết cần tinh chỉnh.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="557" height="292" alt="image" src="https://github.com/user-attachments/assets/ea25be6a-018c-43b5-91ce-d83743fa217e" />
- Real code
  + Kết quả:
  <img width="534" height="210" alt="image" src="https://github.com/user-attachments/assets/cae5f828-07e9-4cf6-80fe-adecae043053" />

