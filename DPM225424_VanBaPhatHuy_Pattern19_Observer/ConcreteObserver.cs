
/// <summary>
/// Lớp 'ConcreteObserver' – triển khai Observer, đồng bộ trạng thái với Subject
/// </summary>
public class ConcreteObserver : Observer
{
    private string name;                // Tên của Observer (để hiển thị)
    private string observerState;       // Trạng thái cục bộ của Observer
    private ConcreteSubject subject;    // Tham chiếu đến Subject đang quan sát

    // Hàm khởi tạo
    public ConcreteObserver(ConcreteSubject subject, string name)
    {
        this.subject = subject;
        this.name = name;
    }

    // Khi Subject thông báo, đồng bộ trạng thái và in ra
    public override void Update()
    {
        observerState = subject.SubjectState;
        Console.WriteLine("Observer {0} có trạng thái mới là {1}", name, observerState);
    }

    // Thuộc tính get/set Subject
    public ConcreteSubject Subject
    {
        get { return subject; }
        set { subject = value; }
    }
}
