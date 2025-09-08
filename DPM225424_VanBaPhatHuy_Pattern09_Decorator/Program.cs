using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một ConcreteComponent (đối tượng gốc)
        ConcreteComponent c = new ConcreteComponent();

        // Tạo hai Decorator cụ thể
        ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        ConcreteDecoratorB d2 = new ConcreteDecoratorB();

        // Liên kết decorator: d1 bọc quanh c, d2 bọc quanh d1
        d1.SetComponent(c);
        d2.SetComponent(d1);

        // Gọi Operation từ decorator ngoài cùng (d2)
        d2.Operation();

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
