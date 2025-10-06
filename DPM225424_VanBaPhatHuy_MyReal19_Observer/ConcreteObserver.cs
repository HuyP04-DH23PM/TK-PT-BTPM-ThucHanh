using System;

/// <summary>
/// Lớp 'ConcreteObserver' – kênh nhận thông báo (ZaloBot/Kho/KếToán)
/// Đồng bộ trạng thái với Subject (đơn hàng)
/// </summary>
public class ConcreteObserver : Observer
{
    private string name;                // Tên kênh/ bộ phận
    private string observerState;       // Trạng thái cục bộ
    private ConcreteSubject subject;    // Subject đang quan sát

    public ConcreteObserver(ConcreteSubject subject, string name)
    {
        this.subject = subject;
        this.name = name;
    }

    public override void Update()
    {
        observerState = subject.SubjectState;
        Console.WriteLine($"🔔 [{name}] nhận thông báo: {observerState}");
    }

    public ConcreteSubject Subject
    {
        get { return subject; }
        set { subject = value; }
    }
}
