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

#Mẫu số 11 - Flyweight
<span style="color:#00FFFF;"> 
- Dùng khi: Có rất nhiều đối tượng “vi hạt” tương tự nhau làm tốn RAM; phần lớn trạng thái có thể dùng chung; cần tạo/huỷ nhanh. 
- Giải quyết: Tách **trạng thái nội sinh** để chia sẻ (flyweight), còn **trạng thái ngoại sinh** truyền vào lúc sử dụng. 
- Ưu điểm: Tiết kiệm bộ nhớ lớn; giảm chi phí khởi tạo; dễ cache/đệm đối tượng dùng chung. 
- Nhược điểm: Quản lý trạng thái ngoại sinh phức tạp; tăng độ rối khi debug; cần lưu ý thread-safety. </span>

- Structual Code (Pattern)
   + Kết quả:
  <img width="535" height="242" alt="image" src="https://github.com/user-attachments/assets/2a908e38-e6c8-42f0-b12e-b2ef058d536c" />
- Real code
  + Kết quả:
  <img width="529" height="234" alt="image" src="https://github.com/user-attachments/assets/dfe3c1eb-6925-4eef-8423-0d5b01fb42bf" />

#Mẫu số 12 - Proxy
<span style="color:#00FFFF;"> 
- Dùng khi: Cần **đại diện/ủy quyền** cho đối tượng thật: kiểm soát truy cập, lazy init, remote proxy, protection, logging, caching.
- Giải quyết: Tạo lớp Proxy cùng giao diện, **chặn & điều phối** lời gọi đến đối tượng thật (trước/sau có thêm logic).
- Ưu điểm: Minh bạch với client; hỗ trợ lazy/caching/bảo vệ/log; tách mối quan tâm.
- Nhược điểm: Thêm tầng gián tiếp → tăng độ trễ/độ phức tạp; phải đồng bộ API với đối tượng thật.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="515" height="124" alt="image" src="https://github.com/user-attachments/assets/e7966d15-df27-4b66-bd3b-3d777e76ea89" />
- Real code
  + Kết quả:
  <img width="476" height="179" alt="image" src="https://github.com/user-attachments/assets/811d8eba-4f01-48dd-bc29-98dd76325e84" />

#Mẫu số 13 - Chain of Responsibility
<span style="color:#00FFFF;"> 
- Dùng khi: Có **nhiều handler** tiềm năng; không muốn client biết ai xử lý; quy tắc xử lý có thể thay đổi thứ tự/danh sách.
- Giải quyết: Xây **chuỗi handler**; request đi dọc chuỗi cho đến khi có handler chấp nhận/ xử lý.
- Ưu điểm: Giảm kết dính sender–receiver; dễ thêm/bớt/sắp xếp handler; cấu hình linh hoạt.
- Nhược điểm: Không đảm bảo có ai xử lý; khó debug dòng chảy; có overhead chuyển tiếp.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="726" height="345" alt="image" src="https://github.com/user-attachments/assets/cddfa347-7052-4b5b-89a0-8c19d4b7ae8a" />
- Real code
  + Kết quả:
  <img width="669" height="279" alt="image" src="https://github.com/user-attachments/assets/886c49a0-8acf-4220-b980-49c9d0f0f884" />

#Mẫu số 14 - Command
<span style="color:#00FFFF;"> 
- Dùng khi: Cần **đóng gói yêu cầu** thành đối tượng để hỗ trợ undo/redo, log, queue, macro; tách Invoker khỏi Receiver.
- Giải quyết: Lớp `Command` chứa hành động + dữ liệu; Invoker gọi, Receiver thi hành.
- Ưu điểm: Hỗ trợ undo/redo & lịch/queue; ghép lệnh thành macro; mở rộng dễ (OCP).
- Nhược điểm: Tăng số lượng lớp; boilerplate; cần quản lý lịch sử lệnh.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="483" height="142" alt="image" src="https://github.com/user-attachments/assets/b17381f3-a847-4346-8ba1-ae97e1ee2c9b" />
- Real code
  + Kết quả:
  <img width="474" height="141" alt="image" src="https://github.com/user-attachments/assets/dc1a7335-f134-40af-9cab-f012fccce50d" />

#Mẫu số 15 - Interpreter
<span style="color:#00FFFF;"> 
- Dùng khi: Cần nhúng **ngôn ngữ mini/DSL nhỏ** (biểu thức, luật, filter) vào chương trình.
- Giải quyết: Mô hình hóa ngữ pháp thành cây biểu thức (AST) và **thông dịch** qua các lớp Expression.
- Ưu điểm: Dễ mở rộng ngữ pháp miền hẹp; cấu trúc rõ ràng; kiểm thử từng non/terminal dễ.
- Nhược điểm: Hiệu năng kém cho ngữ pháp lớn; “nổ” lớp; với DSL phức tạp nên dùng parser/engine chuyên dụng.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="477" height="140" alt="image" src="https://github.com/user-attachments/assets/375ae72b-b8fa-4dc0-bc90-0e499ea7dce4" />
- Real code
  + Kết quả:
  <img width="477" height="145" alt="image" src="https://github.com/user-attachments/assets/6581b744-34b0-4e4a-9d31-ace0df29aa61" />

#Mẫu số 16 - Iterator
<span style="color:#00FFFF;"> 
- Dùng khi: Muốn **duyệt tuần tự** phần tử mà không lộ cấu trúc lưu trữ; cần nhiều kiểu duyệt độc lập.
- Giải quyết: Cung cấp **iterator** tách biệt với collection để điều hướng (first/next/current/isDone).
- Ưu điểm: API duyệt thống nhất; hỗ trợ nhiều iterator song song; thay đổi cấu trúc mà không đổi cách duyệt.
- Nhược điểm: Overhead đối tượng/biên giới; invalidation khi collection thay đổi; nhiều ngôn ngữ hiện đại đã có sẵn.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="590" height="255" alt="image" src="https://github.com/user-attachments/assets/0314f5ef-6a98-4640-a242-c369c132b308" />
- Real code
  + Kết quả:
  <img width="596" height="258" alt="image" src="https://github.com/user-attachments/assets/36fd7cb1-1aa7-459c-bb12-dd35e56b5ee4" />

#Mẫu số 17 - Mediator
<span style="color:#00FFFF;"> 
- Dùng khi: Quan hệ **nhiều–nhiều** giữa các đối tượng làm hệ thống rối (ví dụ UI widgets).
- Giải quyết: Gom **logic tương tác** vào một Mediator trung tâm; các colleague chỉ nói chuyện với Mediator.
- Ưu điểm: Giảm kết dính đồng nghiệp; giao thức tương tác rõ ràng; thay đổi hành vi tương tác dễ.
- Nhược điểm: Mediator dễ thành “god object”; dồn phức tạp vào một chỗ; cần tách nhỏ khi lớn.
- </span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="595" height="254" alt="image" src="https://github.com/user-attachments/assets/861be383-e58e-4d7a-8ba9-d7a5fa74aa7c" />
- Real code
  + Kết quả:
  <img width="592" height="253" alt="image" src="https://github.com/user-attachments/assets/811c2ef9-a097-488e-993e-7ee0a816685e" />

#Mẫu số 18 - Memento
<span style="color:#00FFFF;"> 
- Dùng khi: Cần **lưu & khôi phục** trạng thái nội bộ (undo/redo, rollback) mà vẫn giữ bao đóng.
- Giải quyết: Tạo **ảnh chụp trạng thái** (Memento) do Originator phát sinh; Caretaker cất giữ.
- Ưu điểm: Undo/redo tự nhiên; không lộ chi tiết nội bộ; time-travel trạng thái.
- Nhược điểm: Tốn bộ nhớ/serialize; quản lý vòng đời memento; nguy cơ rò rỉ nếu lưu quá nhiều.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="594" height="250" alt="image" src="https://github.com/user-attachments/assets/cbce18fb-5148-481f-8dcf-4e245271cf79" />
- Real code
  + Kết quả:
  <img width="764" height="424" alt="image" src="https://github.com/user-attachments/assets/7a00658e-386c-4f50-b1c5-142d31e75681" />

#Mẫu số 19 - Observer
<span style="color:#00FFFF;"> 
- Dùng khi: Nhiều bên cần **nhận thông báo** khi Subject đổi trạng thái (GUI, MV*, event bus).
- Giải quyết: Subject quản danh sách observer và **Notify()** khi thay đổi.
- Ưu điểm: Kết dính lỏng; mở rộng dễ; mô hình sự kiện tự nhiên.
- Nhược điểm: Thứ tự/bội số cập nhật khó kiểm soát; memory leak do quên detach; khó debug chuỗi sự kiện.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="488" height="187" alt="image" src="https://github.com/user-attachments/assets/c7e40ffb-74de-4b80-b0d5-eba5dd407ee0" />
- Real code
  + Kết quả:
    <img width="662" height="181" alt="image" src="https://github.com/user-attachments/assets/df98175e-6c84-491f-9c1d-c89cc3c4b131" />

Mẫu số 20 - State
<span style="color:#00FFFF;"> 
- Dùng khi: Hành vi **phụ thuộc trạng thái** và thay đổi theo thời gian; có nhiều `if/else` theo state.
- Giải quyết: Đưa logic theo trạng thái vào các lớp **State**; Context ủy quyền và chuyển state động.
- Ưu điểm: Loại bỏ switch lớn; gom logic theo state; thêm state mới không đụng code cũ (OCP).
- Nhược điểm: Nhiều lớp nhỏ; quản lý chuyển state phân tán; có overhead khởi tạo/chuyển đổi.
</span>

- Structual Code (Pattern)
  + Kết quả:
    <img width="553" height="214" alt="image" src="https://github.com/user-attachments/assets/497bd75f-1641-4208-98d7-2697732d096b" />
- Real code
  + Kết quả:
    <img width="551" height="217" alt="image" src="https://github.com/user-attachments/assets/61dee67d-dfb0-40ae-a9bc-fef2a5f57322" />

Mẫu số 21 - Strategy
<span style="color:#00FFFF;"> 
- Dùng khi: Có **nhiều thuật toán tương đương**; muốn hoán đổi lúc chạy; tránh `if/else` chọn thuật toán.
- Giải quyết: Định nghĩa giao diện Strategy; mỗi thuật toán là một lớp, **thay thế lẫn nhau**.
- Ưu điểm: Linh hoạt; tuân OCP; dễ test/so sánh; kết hợp với DI chọn chiến lược.
- Nhược điểm: Tăng số lớp; client cần biết/tiêm đúng chiến lược; overhead gọi gián tiếp.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="555" height="216" alt="image" src="https://github.com/user-attachments/assets/2c5a6b3b-dcf9-429b-947a-eb412bebff0d" />
- Real code
  + Kết quả:
  <img width="555" height="216" alt="image" src="https://github.com/user-attachments/assets/79e57c98-f147-43fb-9205-8dcf35f62ec4" />
  
#Mẫu số 12 - Template Method
<span style="color:#00FFFF;"> 
- Dùng khi: Muốn **cố định khung thuật toán** nhưng cho phép lớp con tùy biến **các bước** cụ thể.
- Giải quyết: Lớp cha định nghĩa **Template Method** (trình tự bước); lớp con override bước nguyên thủy.
- Ưu điểm: Tái dùng cao; đảm bảo trình tự; mở rộng có kiểm soát qua hook.
- Nhược điểm: Phụ thuộc kế thừa (cứng nhắc hơn composition); khó thay đổi khung lúc chạy; base fragile nếu lạm dụng.
</span>

- Structual Code (Pattern)
  + Kết quả:
  <img width="551" height="217" alt="image" src="https://github.com/user-attachments/assets/8d761832-6d69-4733-b9af-d52372c30676" />
- Real code
  + Kết quả:
  <img width="546" height="216" alt="image" src="https://github.com/user-attachments/assets/bff1bc58-e530-4294-a4c1-3df28a84b5e9" />


