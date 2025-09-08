using System;

// 'ConcreteDecoratorB' là một lớp trang trí cụ thể khác (Concrete Decorator)
// Nó cũng kế thừa từ Decorator và bổ sung thêm hành vi riêng
public class ConcreteDecoratorB : Decorator
{
    // Ghi đè phương thức Operation
    public override void Operation()
    {
        // Gọi hành vi gốc (qua Decorator → Component bên trong)
        base.Operation();

        // Thêm hành vi riêng trước khi in ra
        AddedBehavior();

        // Hành vi bổ sung cụ thể của ConcreteDecoratorB
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    // Phương thức bổ sung (có thể chứa logic riêng)
    void AddedBehavior()
    {
        // Có thể thêm logic đặc thù ở đây (hiện tại để trống)
    }
}
