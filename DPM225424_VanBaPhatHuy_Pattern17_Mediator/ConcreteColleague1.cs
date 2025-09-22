
/// <summary>
/// Lớp 'ConcreteColleague1' – giao tiếp thông qua Mediator
/// </summary>
public class ConcreteColleague1 : Colleague
{
    // Khởi tạo kèm Mediator
    public ConcreteColleague1(Mediator mediator) : base(mediator) { }

    // Gửi tin nhắn nhờ Mediator chuyển tiếp
    public void Send(string message)
    {
        mediator.Send(message, this);
    }

    // Nhận thông báo từ Mediator
    public void Notify(string message)
    {
        Console.WriteLine("Colleague1 nhận tin: " + message);
    }
}
