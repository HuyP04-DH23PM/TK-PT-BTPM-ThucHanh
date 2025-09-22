
/// <summary>
/// Lớp cụ thể 'ConcreteClassA' – hiện thực các bước nguyên thủy
/// </summary>
public class ConcreteClassA : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("Gọi ConcreteClassA.PrimitiveOperation1()");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("Gọi ConcreteClassA.PrimitiveOperation2()");
    }
}
