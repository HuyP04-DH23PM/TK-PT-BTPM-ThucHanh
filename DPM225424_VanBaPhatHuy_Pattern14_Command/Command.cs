
/// <summary>
/// Lớp trừu tượng Command – định nghĩa giao diện cho các lệnh
/// </summary>
public abstract class Command
{
    // Đối tượng thực hiện hành động (Receiver)
    protected Receiver receiver;

    // Hàm khởi tạo: gán Receiver cho lệnh
    public Command(Receiver receiver)
    {
        this.receiver = receiver;
    }

    // Phương thức trừu tượng để thực thi lệnh
    public abstract void Execute();
}
