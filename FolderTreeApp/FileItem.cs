// -----------------------------
// 2️⃣ Leaf: File
// -----------------------------
using System.Xml.Linq;

public class FileItem : FileSystemItem
{
    private int size;
    public FileItem(string name) : base(name)
    {
        Console.Write($"Nhập dung lượng cho file {name}: ");
        size = int.Parse(Console.ReadLine());
    }

    public override int GetSize() => size;

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + $"{name} ({size} KB)");
    }
}