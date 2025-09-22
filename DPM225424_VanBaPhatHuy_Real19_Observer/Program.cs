using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Observer (Quan sát) – ví dụ thực tế: cổ phiếu (Subject) và nhà đầu tư (Observer)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo cổ phiếu IBM và đăng ký các nhà đầu tư theo dõi
        IBM ibm = new IBM("IBM", 120.00);
        ibm.Attach(new Investor("Sorros"));
        ibm.Attach(new Investor("Berkshire"));

        // Giá dao động → Subject thông báo cho tất cả Observer
        ibm.Price = 120.10;
        ibm.Price = 121.00;
        ibm.Price = 120.50;
        ibm.Price = 120.75;

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
