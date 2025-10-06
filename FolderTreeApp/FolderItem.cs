
// -----------------------------
// 3️⃣ Composite: Folder
// -----------------------------

public class FolderItem : FileSystemItem
{
    private List<FileSystemItem> children = new List<FileSystemItem>();
    public FolderItem(string name) : base(name) { }

    public void Add(FileSystemItem item)
    {
        children.Add(item);
    }

    public override int GetSize()
    {
        int total = 0;
        foreach (var item in children)
            total += item.GetSize();
        return total;
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + $"{name} ({GetSize()} KB)");
        foreach (var item in children)
            item.Display(depth + 2);
    }
}