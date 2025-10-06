using System;
using System.Text;

/// <summary>
/// Demo Command Pattern – MyReal (xử lý đơn hàng nông dược)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo Receiver (nghiệp vụ kho/đơn hàng), Command (mệnh lệnh), Invoker (nút gọi lệnh)
        var receiver = new Receiver();
        var command = new ConcreteCommand(receiver, "AGU-ORDER-001");
        var invoker = new Invoker();

        invoker.SetCommand(command);
        invoker.ExecuteCommand();   // Thực thi chuỗi thao tác thực tế

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
