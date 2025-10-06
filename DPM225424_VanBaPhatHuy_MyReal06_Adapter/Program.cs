using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Hệ thống quản lý cửa hàng chỉ biết làm việc với Target
        Target camBienDoAm = new Adapter();

        // Khi gọi Request() → Adapter sẽ chuyển sang gọi hệ thống cũ
        camBienDoAm.Request();

        Console.ReadKey();
    }
}
