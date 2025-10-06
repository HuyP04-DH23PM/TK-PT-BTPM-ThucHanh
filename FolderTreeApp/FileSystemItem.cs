// -----------------------------
// 1️⃣ Component: Item (Folder/File)
// -----------------------------
public abstract class FileSystemItem
{
    protected string name;
    public FileSystemItem(string name)
    {
        this.name = name;
    }
    public abstract int GetSize();      // Dung lượng
    public abstract void Display(int depth);
}