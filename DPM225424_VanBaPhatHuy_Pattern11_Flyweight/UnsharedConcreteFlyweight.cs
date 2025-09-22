/// <summary>
/// Lớp 'UnsharedConcreteFlyweight'
/// </summary>
public class UnsharedConcreteFlyweight : Flyweight
{
    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
    }
}