using System;

/// <summary>
/// 'ConcreteColleague1' – MyReal: QUẦY BÁN HÀNG
/// Gửi yêu cầu lấy hàng / xác nhận tồn kho qua Mediator
/// </summary>
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Console.WriteLine($"🛒 [Bán hàng] Gửi: {message}");
        mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("🛒 [Bán hàng] Nhận: " + message);
    }
}
