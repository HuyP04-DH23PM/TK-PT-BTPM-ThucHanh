/// <summary>
/// Invoker – nơi lưu và kích hoạt lệnh (ví dụ: nút "Xử lý đơn" trên UI)
/// </summary>
public class Invoker
{
    private Command command;

    public void SetCommand(Command command)
    {
        this.command = command;
    }

    public void ExecuteCommand()
    {
        command.Execute();
    }
}
