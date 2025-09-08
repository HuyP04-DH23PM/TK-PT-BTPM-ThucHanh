using System;

// 'ConcreteImplementorA' là một lớp cài đặt cụ thể trong Bridge Pattern
// Nó kế thừa từ lớp trừu tượng Implementor
public class ConcreteImplementorA : Implementor
{
    // Thực hiện phương thức Operation theo cách riêng của A
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorA Operation");
    }
}
