using System;

// 'ConcreteImplementorB' là một lớp cài đặt cụ thể khác (Concrete Implementor)
// Nó cũng kế thừa từ Implementor nhưng có cách thực hiện Operation khác với A
public class ConcreteImplementorB : Implementor
{
    // Thực hiện phương thức Operation theo cách riêng của B
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorB Operation");
    }
}
