using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế Proxy (Đại diện/Ủy quyền truy cập) - MyReal
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo Proxy và cấu hình API key (quyền truy cập dịch vụ kho)
        Proxy proxy = new Proxy
        {
            ApiKey = "AGU-KEY-2025" // thử đổi sai để thấy bị chặn
        };

        // Gọi dịch vụ qua Proxy
        proxy.Request();

        // Gọi lại lần 2 để thấy RealSubject đã được khởi tạo sẵn (không khởi tạo lại)
        Console.WriteLine("\n— Gọi lại lần 2 —");
        proxy.Request();

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
