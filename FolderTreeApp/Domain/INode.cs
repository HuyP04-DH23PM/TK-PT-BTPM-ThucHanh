namespace FolderTreeApp.Domain;

public interface INode
{
    string Name { get; }
    void Display(string indent = "");
}
