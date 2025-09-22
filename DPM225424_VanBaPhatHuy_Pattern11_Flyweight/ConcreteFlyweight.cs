/// <summary>
/// Lớp 'ConcreteFlyweight'
/// </summary>
public class ConcreteFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
}