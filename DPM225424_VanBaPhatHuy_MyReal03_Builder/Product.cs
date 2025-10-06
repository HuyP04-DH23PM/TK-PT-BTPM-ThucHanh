using System;
using System.Collections.Generic;

// Gói sản phẩm nông dược hoàn chỉnh
class Product
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("\n🧾 Gói sản phẩm nông dược gồm:");
        foreach (var part in _parts)
            Console.WriteLine($"   - {part}");
    }
}
