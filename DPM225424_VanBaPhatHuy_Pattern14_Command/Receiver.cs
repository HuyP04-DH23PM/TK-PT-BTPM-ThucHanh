
using System.Text;

/// <summary>
/// Lớp Receiver – chứa logic thực tế của hành động được yêu cầu
/// </summary>
public class Receiver
{
    public void Action()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Đã gọi Receiver.Action()");
    }
}
