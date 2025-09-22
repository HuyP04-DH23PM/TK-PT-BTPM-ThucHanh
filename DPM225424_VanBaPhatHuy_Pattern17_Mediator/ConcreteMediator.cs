
/// <summary>
/// Lớp 'ConcreteMediator' – điều phối việc gửi/nhận giữa các Colleague
/// </summary>
public class ConcreteMediator : Mediator
{
    // Tham chiếu đến các "đồng nghiệp" tham gia liên lạc
    private ConcreteColleague1 colleague1;
    private ConcreteColleague2 colleague2;

    // Thiết lập đồng nghiệp 1
    public ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }

    // Thiết lập đồng nghiệp 2
    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }

    // Định tuyến thông điệp: nếu người gửi là c1 → chuyển cho c2; ngược lại chuyển cho c1
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            colleague2.Notify(message);
        }
        else
        {
            colleague1.Notify(message);
        }
    }
}
