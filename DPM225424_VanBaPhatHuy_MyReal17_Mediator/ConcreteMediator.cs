/// <summary>
/// 'ConcreteMediator' – MyReal: Điều phối liên lạc giữa Bán hàng và Kho
/// </summary>
public class ConcreteMediator : Mediator
{
    private ConcreteColleague1 colleague1; // Bán hàng
    private ConcreteColleague2 colleague2; // Kho

    public ConcreteColleague1 Colleague1 { set { colleague1 = value; } }
    public ConcreteColleague2 Colleague2 { set { colleague2 = value; } }

    // Định tuyến thông điệp và thêm ngữ cảnh người gửi
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            // Từ Bán hàng → Kho
            colleague2.Notify($"[Từ Bán hàng] {message}");
        }
        else
        {
            // Từ Kho → Bán hàng
            colleague1.Notify($"[Từ Kho] {message}");
        }
    }
}
