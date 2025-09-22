
/// <summary>
/// Lớp trừu tượng 'Subject' – quản lý danh sách Observer và phát thông báo
/// </summary>
public abstract class Subject
{
    // Danh sách các Observer đã đăng ký theo dõi Subject này
    private List<Observer> observers = new List<Observer>();

    // Thêm một Observer vào danh sách
    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    // Gỡ một Observer khỏi danh sách
    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }

    // Gửi thông báo cho tất cả Observer (gọi Update)
    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Update();
        }
    }
}
