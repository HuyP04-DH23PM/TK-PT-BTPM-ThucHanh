using System;

// 'ConcreteComponent' là thành phần cụ thể (Concrete Component)
// Nó kế thừa từ Component và cài đặt chi tiết cho Operation()
public class ConcreteComponent : Component
{
    // Thực hiện Operation cụ thể
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}
