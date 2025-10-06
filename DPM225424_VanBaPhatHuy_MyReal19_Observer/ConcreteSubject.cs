/// <summary>
/// 'ConcreteSubject' – đơn hàng/ trung tâm thông báo trạng thái
/// </summary>
public class ConcreteSubject : Subject
{
    private string subjectState;

    // Ví dụ trạng thái: "AGU-ORDER-001 | Khách đã thanh toán"
    public string SubjectState
    {
        get { return subjectState; }
        set { subjectState = value; }
    }
}
