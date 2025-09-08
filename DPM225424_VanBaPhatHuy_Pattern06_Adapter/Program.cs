/// <summary>
/// Adapter Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create adapter and place a request
        Target target = new Adapter();
        target.Request();
        // Wait for user
        Console.ReadKey();
    }
}