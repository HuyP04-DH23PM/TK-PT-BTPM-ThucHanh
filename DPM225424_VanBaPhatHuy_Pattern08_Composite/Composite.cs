public class Composite : Component
{
    List<Component> children = new List<Component>();

    // Hàm khởi tạo

    public Composite(string name)
        : base(name)
    {
    }

    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);

        // Recursively display child nodes

        foreach (Component component in children)
        {
            component.Display(depth + 2);
        }
    }
}