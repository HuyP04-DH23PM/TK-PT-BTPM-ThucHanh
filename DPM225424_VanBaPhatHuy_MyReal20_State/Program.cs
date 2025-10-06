using System;
using System.Text;

/// <summary>
/// State Pattern – MyReal: Mở bán ↔ Tạm dừng (cửa hàng nông dược)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var context = new Context(new ConcreteStateA());

        // Mỗi lần Request là một chu kỳ vận hành → chuyển trạng thái
        context.Request(); // A -> B
        Console.WriteLine();

        context.Request(); // B -> A
        Console.WriteLine();

        context.Request(); // A -> B
        Console.WriteLine();

        context.Request(); // B -> A

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
