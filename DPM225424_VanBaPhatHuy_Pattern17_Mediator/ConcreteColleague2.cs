
/// <summary>
/// Lớp 'ConcreteColleague2' – giao tiếp thông qua Mediator
/// </summary>
public class ConcreteColleague2 : Colleague
{
    // Khởi tạo kèm Mediator
    public ConcreteColleague2(Mediator mediator) : base(mediator) { }

    // Gửi tin nhắn nhờ Mediator chuyển tiếp
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    // Nhận thông báo từ Mediator
    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 nhận tin: " + message);
    }
}
