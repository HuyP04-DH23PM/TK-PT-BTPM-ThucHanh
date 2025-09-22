
/// <summary>
/// Lớp Invoker – lưu trữ lệnh và kích hoạt lệnh khi cần
/// </summary>
public class Invoker
{
    // Tham chiếu đến lệnh cần thực hiện
    Command command;

    // Thiết lập lệnh
    public void SetCommand(Command command)
    {
        this.command = command;
    }

    // Thực thi lệnh đã thiết lập
    public void ExecuteCommand()
    {
        command.Execute();
    }
}
