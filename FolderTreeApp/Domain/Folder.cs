using System.Collections.Generic;

namespace FolderTreeApp.Domain;

public class Folder : INode
{
    public string Name { get; }
    private readonly List<INode> _children = new();

    public Folder(string name) => Name = name;
    public void Add(INode node) => _children.Add(node);

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}📁 {Name} ({FormatSize(GetSize())})");
        foreach (var c in _children) c.Display(indent + "   ");
    }

    public long GetSize()
    {
        long total = 0;
        foreach (var c in _children)
            total += c.GetSize();
        return total;
    }

    private static string FormatSize(long bytes)
    {
        if (bytes > 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F2} MB";
        if (bytes > 1024) return $"{bytes / 1024.0:F2} KB";
        return $"{bytes} B";
    }
}
