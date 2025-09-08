using System;

// 'ConcreteDecoratorA' là một lớp trang trí cụ thể (Concrete Decorator)
// Nó kế thừa từ Decorator và có thể thêm hành vi mới vào Component
public class ConcreteDecoratorA : Decorator
{
    // Ghi đè phương thức Operation
    public override void Operation()
    {
        // Gọi lại Operation gốc từ lớp cha (Decorator → Component gốc)
        base.Operation();

        // Thêm hành vi bổ sung riêng của ConcreteDecoratorA
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}
