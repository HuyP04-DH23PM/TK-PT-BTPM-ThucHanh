using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế Template (Khuôn mẫu) – định nghĩa khung thuật toán và cho phép lớp con bổ sung bước cụ thể
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo các lớp cụ thể và chạy khuôn mẫu
        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();

        AbstractClass aB = new ConcreteClassB();
        aB.TemplateMethod();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
