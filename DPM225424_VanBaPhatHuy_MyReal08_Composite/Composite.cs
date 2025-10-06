using System;
using System.Collections.Generic;

// 'Composite' đại diện cho NHÓM danh mục (có thể chứa nhóm con hoặc sản phẩm)
public class Composite : Component
{
    private readonly List<Component> children = new List<Component>();

    public Composite(string name) : base(name) { }

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
        Console.WriteLine(new string('-', depth) + "📁 " + name);
        foreach (var child in children)
        {
            child.Display(depth + 2);
        }
    }
}
