using System;

/// <summary>
/// Mẫu thiết kế Proxy (Đại diện/Ủy quyền thực hiện phép toán)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo Proxy cho lớp Math
        MathProxy proxy = new MathProxy();

        // Thực hiện các phép toán thông qua Proxy
        Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
        Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
        Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
        Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
