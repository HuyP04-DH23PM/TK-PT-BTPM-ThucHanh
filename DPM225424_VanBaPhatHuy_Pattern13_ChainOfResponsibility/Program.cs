using System;

/// <summary>
/// Mẫu thiết kế Chain of Responsibility (Chuỗi trách nhiệm)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Thiết lập chuỗi trách nhiệm (tạo các Handler và nối chuỗi)
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();
        h1.SetSuccessor(h2); // h1 chuyển tiếp cho h2
        h2.SetSuccessor(h3); // h2 chuyển tiếp cho h3

        // Sinh ra các yêu cầu và xử lý qua chuỗi
        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

        // Gửi từng yêu cầu cho Handler đầu tiên trong chuỗi
        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
