using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế Mediator (Trung gian) – các đối tượng giao tiếp thông qua "người điều phối"
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo Mediator cụ thể (trung gian điều phối thông điệp)
        ConcreteMediator m = new ConcreteMediator();

        // Tạo các "đồng nghiệp" và gắn Mediator
        ConcreteColleague1 c1 = new ConcreteColleague1(m);
        ConcreteColleague2 c2 = new ConcreteColleague2(m);

        // Cho Mediator biết hai đầu mối sẽ liên lạc qua mình
        m.Colleague1 = c1;
        m.Colleague2 = c2;

        // Gửi tin nhắn thông qua Mediator (không gửi trực tiếp cho nhau)
        c1.Send("Bạn khỏe không?");
        c2.Send("Mình ổn, cảm ơn nha!");

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
