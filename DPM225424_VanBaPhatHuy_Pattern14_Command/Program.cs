using System;

/// <summary>
/// Mẫu thiết kế Command (Mệnh lệnh) – tách yêu cầu ra khỏi đối tượng thực hiện
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng Receiver (người nhận), Command (mệnh lệnh) và Invoker (người gọi lệnh)
        Receiver receiver = new Receiver();
        Command command = new ConcreteCommand(receiver);
        Invoker invoker = new Invoker();

        // Gán lệnh cho Invoker và thực thi lệnh
        invoker.SetCommand(command);
        invoker.ExecuteCommand();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
