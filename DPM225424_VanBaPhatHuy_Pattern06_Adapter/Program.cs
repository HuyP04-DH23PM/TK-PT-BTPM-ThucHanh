using System;

// Demo Adapter Design Pattern
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một đối tượng Adapter (đóng vai trò "cầu nối")
        // Client chỉ biết đến Target, nhưng thực tế Adapter sẽ gọi Adaptee
        Target target = new Adapter();

        // Gọi phương thức Request() như mong muốn
        // Thực chất nó sẽ chuyển tiếp sang Adaptee.SpecificRequest()
        target.Request();

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
