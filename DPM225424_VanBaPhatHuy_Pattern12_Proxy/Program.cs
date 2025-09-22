using System;

/// <summary>
/// Mẫu thiết kế Proxy (Đại diện/Ủy quyền truy cập)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng Proxy và gọi dịch vụ qua Proxy
        Proxy proxy = new Proxy();
        proxy.Request();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
