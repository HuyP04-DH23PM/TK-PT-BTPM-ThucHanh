using System.IO;

namespace FolderTreeApp.Domain;

public class FileNode : INode
{
    public string Name { get; }
    public string? FullPath { get; set; }  // tuỳ chọn nếu cần liên kết file thật

    public FileNode(string name)
    {
        Name = name;
    }

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name} ({FormatSize(GetSize())})");
    }

    public long GetSize()
    {
        // Nếu file thật tồn tại → lấy size thật
        if (!string.IsNullOrEmpty(FullPath) && File.Exists(FullPath))
        {
            return new FileInfo(FullPath).Length;
        }

        // Nếu chỉ mô phỏng → có thể trả size random hoặc 0
        // Ở bài kiểm tra thường đọc file thật → nên ưu tiên cách trên
        return 0;
    }

    private static string FormatSize(long bytes)
    {
        if (bytes > 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F2} MB";
        if (bytes > 1024) return $"{bytes / 1024.0:F2} KB";
        return $"{bytes} B";
    }
}
