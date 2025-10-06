namespace FolderTreeApp.Domain;

public class FileNode : INode
{
    public string Name { get; }
    public FileNode(string name) => Name = name;
    public void Display(string indent = "") => Console.WriteLine($"{indent}- {Name}");
}
