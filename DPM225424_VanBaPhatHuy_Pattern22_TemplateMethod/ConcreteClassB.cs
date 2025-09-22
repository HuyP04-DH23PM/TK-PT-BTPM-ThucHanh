
/// <summary>
/// Lớp cụ thể 'ConcreteClassB' – hiện thực các bước nguyên thủy
/// </summary>
public class ConcreteClassB : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("Gọi ConcreteClassB.PrimitiveOperation1()");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("Gọi ConcreteClassB.PrimitiveOperation2()");
    }
}
