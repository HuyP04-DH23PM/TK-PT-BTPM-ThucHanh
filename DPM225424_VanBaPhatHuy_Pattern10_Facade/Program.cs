using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một đối tượng Facade
        Facade facade = new Facade();

        // Client chỉ cần gọi các phương thức đơn giản của Facade
        // Facade sẽ lo việc điều phối nhiều subsystem bên trong
        facade.MethodA();
        facade.MethodB();

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
