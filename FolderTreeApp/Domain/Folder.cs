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
        Console.WriteLine($"{indent}📁 {Name}");
        foreach (var c in _children) c.Display(indent + "   ");
    }
}
