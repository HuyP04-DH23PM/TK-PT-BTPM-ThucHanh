using System;
using System.Text;

/// <summary>
/// Mediator Pattern – MyReal: Quầy Bán Hàng ↔ Kho (điều phối qua Mediator)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo Mediator và các "đồng nghiệp"
        var m = new ConcreteMediator();
        var c1 = new ConcreteColleague1(m); // Bán hàng
        var c2 = new ConcreteColleague2(m); // Kho

        // Gắn vào Mediator
        m.Colleague1 = c1;
        m.Colleague2 = c2;

        // Luồng thực tế:
        c1.Send("Đơn AGU-ORDER-001 cần 2 bao Phân hữu cơ 25kg + 1 chai AGU Bio 1L. Kiểm tra tồn giúp!");
        c2.Send("Tồn kho OK. Dự kiến giao nội tỉnh hôm nay. Vui lòng xác nhận thanh toán.");

        c1.Send("Khách đã thanh toán. Tạo vận đơn GHN giúp nhé!");
        c2.Send("Đã tạo vận đơn mã LX-2025-001. Sẽ gửi SMS/Zalo cho khách.");

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
