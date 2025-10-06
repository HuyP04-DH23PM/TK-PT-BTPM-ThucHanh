using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Cây thư mục theo ví dụ
        FolderItem root = new FolderItem("C:\\");

        FolderItem A = new FolderItem("A");
        A.Add(new FileItem("A.cpp"));

        // Sửa lại cách thêm thư mục con A1
        FolderItem A1 = new FolderItem("A1");
        A1.Add(new FileItem("A1.doc"));
        A.Add(A1);

        FolderItem A2 = new FolderItem("A2");
        A2.Add(new FileItem("A2.1.txt"));
        A2.Add(new FileItem("A2.2.doc"));
        A.Add(A2);
        root.Add(A);

        FolderItem B = new FolderItem("B");
        B.Add(new FileItem("B.txt"));
        root.Add(B);

        FolderItem C = new FolderItem("C");
        FolderItem C1 = new FolderItem("C1");
        C1.Add(new FileItem("C1.1.doc"));
        C1.Add(new FileItem("C1.2.exe"));
        C.Add(C1);
        root.Add(C);

        // Hiển thị cây và dung lượng
        Console.WriteLine("\nCây thư mục:");
        root.Display(0);

        Console.WriteLine($"\nTổng dung lượng ổ C: {root.GetSize()} KB");

        Console.ReadKey();
    }
}
