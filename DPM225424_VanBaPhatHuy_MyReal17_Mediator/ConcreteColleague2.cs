using System;

/// <summary>
/// 'ConcreteColleague2' – MyReal: KHO
/// Nhận yêu cầu từ Bán hàng và phản hồi qua Mediator
/// </summary>
public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine($"📦 [Kho] Gửi: {message}");
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("📦 [Kho] Nhận: " + message);
    }
}
