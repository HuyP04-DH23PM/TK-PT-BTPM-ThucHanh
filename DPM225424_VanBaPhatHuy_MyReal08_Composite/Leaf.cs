using System;

// 'Leaf' đại diện cho SẢN PHẨM cụ thể (không chứa con)
public class Leaf : Component
{
    public Leaf(string name) : base(name) { }

    public override void Add(Component c)
    {
        Console.WriteLine($"❌ Không thể thêm mục con vào sản phẩm: {name}");
    }

    public override void Remove(Component c)
    {
        Console.WriteLine($"❌ Không thể xóa mục con khỏi sản phẩm: {name}");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "🛒 " + name);
    }
}
