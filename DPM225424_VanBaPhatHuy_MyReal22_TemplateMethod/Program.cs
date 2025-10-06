using System;
using System.Text;

/// <summary>
/// Template Method – MyReal: khuôn mẫu xử lý đơn hàng nông dược
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("🚀 XỬ LÝ ĐƠN HÀNG THEO KHUÔN MẪU (Template Method)\n");

        AbstractClass aA = new ConcreteClassA(); // Đơn HỮU CƠ
        aA.TemplateMethod();

        AbstractClass aB = new ConcreteClassB(); // Đơn HÓA HỌC
        aB.TemplateMethod();

        Console.WriteLine("Hoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
