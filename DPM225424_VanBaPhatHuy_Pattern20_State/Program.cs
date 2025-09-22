using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế State (Trạng thái) – hành vi của đối tượng thay đổi theo trạng thái nội tại
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khởi tạo Context với trạng thái ban đầu
        var context = new Context(new ConcreteStateA());

        // Gửi các yêu cầu; mỗi lần gọi sẽ "chuyển trạng thái" (toggle) A ↔ B
        context.Request();
        context.Request();
        context.Request();
        context.Request();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
