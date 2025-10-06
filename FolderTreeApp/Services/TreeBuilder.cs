using System.Text;
using FolderTreeApp.Domain;

namespace FolderTreeApp.Services;

public static class TreeBuilder
{
    public static INode BuildFromSpec(string specPath)
    {
        var lines = File.ReadAllLines(specPath, Encoding.UTF8);
        var stack = new Stack<(int indent, Folder node)>();
        Folder? root = null;

        foreach (var raw in lines)
        {
            if (string.IsNullOrWhiteSpace(raw)) continue;
            int indent = raw.TakeWhile(char.IsWhiteSpace).Count();
            string name = raw.Trim();

            // Directory: kết thúc bằng "/"
            bool isDir = name.EndsWith("/");
            string clean = name.TrimEnd('/');

            if (stack.Count == 0)
            {
                // nút gốc (ví dụ "C:\\" hoặc "C:/")
                root = new Folder(clean);
                stack.Push((indent, root));
                continue;
            }

            while (stack.Count > 0 && indent <= stack.Peek().indent) stack.Pop();

            var parent = stack.Peek().node;

            if (isDir)
            {
                var folder = new Folder(clean);
                parent.Add(folder);
                stack.Push((indent, folder));
            }
            else
            {
                parent.Add(new FileNode(clean));
            }
        }

        return root ?? new Folder("ROOT");
    }
}
