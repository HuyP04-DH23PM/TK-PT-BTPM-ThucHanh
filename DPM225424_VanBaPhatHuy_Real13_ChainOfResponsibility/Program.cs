using System;

/// <summary>
/// Mẫu thiết kế Chain of Responsibility (Chuỗi trách nhiệm) – ví dụ thực tế phê duyệt mua hàng
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Thiết lập chuỗi phê duyệt (tạo các cấp duyệt và nối chuỗi)
        Approver larry = new Director();       // Cấp Trưởng phòng: duyệt khoản nhỏ
        Approver sam = new VicePresident();    // Cấp Phó chủ tịch: duyệt khoản trung bình
        Approver tammy = new President();      // Cấp Chủ tịch: duyệt khoản lớn

        larry.SetSuccessor(sam);   // Nếu Director không duyệt được → chuyển cho VP
        sam.SetSuccessor(tammy);   // Nếu VP không duyệt được → chuyển cho President

        // Tạo và xử lý các yêu cầu mua hàng (Purchase)
        Purchase p = new Purchase(2034, 350.00, "Supplies");
        larry.ProcessRequest(p);   // luôn gửi vào đầu chuỗi

        p = new Purchase(2035, 32590.10, "Project X");
        larry.ProcessRequest(p);

        p = new Purchase(2036, 122100.00, "Project Y");
        larry.ProcessRequest(p);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
