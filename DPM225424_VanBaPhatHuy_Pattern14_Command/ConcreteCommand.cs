
/// <summary>
/// Lớp ConcreteCommand – hiện thực một lệnh cụ thể, gọi hành động trên Receiver
/// </summary>
public class ConcreteCommand : Command
{
    // Hàm khởi tạo: truyền Receiver cho lớp cha
    public ConcreteCommand(Receiver receiver) :
        base(receiver)
    {
    }

    public override void Execute()
    {
        // Gọi hành động thực sự trên Receiver
        receiver.Action();
    }
}
