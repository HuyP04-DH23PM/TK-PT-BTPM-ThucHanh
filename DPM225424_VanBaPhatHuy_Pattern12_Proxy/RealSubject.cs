using System.Text;

/// <summary>
/// Lớp 'RealSubject' (Đối tượng thật thực hiện công việc)
/// </summary>
public class RealSubject : Subject
{
    public override void Request()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Đã gọi RealSubject.Request()");
    }
}