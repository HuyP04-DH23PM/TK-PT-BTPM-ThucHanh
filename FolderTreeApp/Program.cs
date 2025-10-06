using FolderTreeApp.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Đặt đường dẫn file đặc tả
var spec = Path.Combine(AppContext.BaseDirectory, "tree.txt");

// Nếu chưa có file mẫu thì tạo sẵn để người dùng sửa
if (!File.Exists(spec))
{
    File.WriteAllText(spec, """
C:\
  A/
    A.app
    A1.doc
    A2.txt
    A22.doc
  B/
    B.txt
  C/
    C1/
      C1.doc
      C12.exe
""");
    Console.WriteLine("Đã tạo tree.txt mẫu. Hãy sửa rồi chạy lại.");
    return;
}

// Xây cây và in ra
var root = TreeBuilder.BuildFromSpec(spec);
Console.WriteLine("📂 Cấu trúc thư mục (từ tree.txt):");
root.Display();

// (Tuỳ chọn) Hỏi có muốn tạo thật ra ổ đĩa không
Console.Write("\nTạo thật ra ổ đĩa? (y/n): ");
if (Console.ReadLine()?.Trim().ToLower() == "y")
{
    CreateRealFolders(spec);
    Console.WriteLine("✅ Đã tạo xong.");
}

// ===== Helper tạo thật =====
static void CreateRealFolders(string specPath)
{
    var lines = File.ReadAllLines(specPath);
    var pathStack = new Stack<(int indent, string path)>();
    foreach (var raw in lines)
    {
        if (string.IsNullOrWhiteSpace(raw)) continue;
        int indent = raw.TakeWhile(char.IsWhiteSpace).Count();
        string name = raw.Trim();
        bool isDir = name.EndsWith("/");

        while (pathStack.Count > 0 && indent <= pathStack.Peek().indent) pathStack.Pop();
        string parent = pathStack.Count == 0 ? "" : pathStack.Peek().path;

        // root (C:\) giữ nguyên
        if (pathStack.Count == 0)
        {
            pathStack.Push((indent, name.TrimEnd('/')));
            continue;
        }

        string full = Path.Combine(parent, name.TrimEnd('/'));

        if (isDir)
        {
            Directory.CreateDirectory(full);
            pathStack.Push((indent, full));
        }
        else
        {
            Directory.CreateDirectory(parent);
            if (!File.Exists(full)) File.WriteAllText(full, "");
        }
    }
}
