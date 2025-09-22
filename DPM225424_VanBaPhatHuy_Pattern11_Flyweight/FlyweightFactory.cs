

/// <summary>
/// Lớp 'FlyweightFactory'
/// </summary>
public class FlyweightFactory
{
    private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();

    // Hàm khởi tạo

    public FlyweightFactory()
    {
        flyweights.Add("X", new ConcreteFlyweight());
        flyweights.Add("Y", new ConcreteFlyweight());
        flyweights.Add("Z", new ConcreteFlyweight());
    }

    public Flyweight GetFlyweight(string key)
    {
        return flyweights[key];
    }
}