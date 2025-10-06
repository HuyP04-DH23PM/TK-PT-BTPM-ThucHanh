using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Client chỉ cần gọi Facade, không phải đụng vào từng subsystem
        Facade facade = new Facade();

        facade.MethodA(); // Xử lý đơn gói hữu cơ: kho + thanh toán + thông báo
        facade.MethodB(); // Hậu cần: thanh toán + vận chuyển

        Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
