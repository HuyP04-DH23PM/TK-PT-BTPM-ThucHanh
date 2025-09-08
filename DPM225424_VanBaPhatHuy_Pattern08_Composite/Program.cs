using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo ra một cây cấu trúc gốc (root)
        Composite root = new Composite("root");
        root.Add(new Leaf("Leaf A"));  // Thêm lá A vào root
        root.Add(new Leaf("Leaf B"));  // Thêm lá B vào root

        // Tạo một Composite con (nhánh X)
        Composite comp = new Composite("Composite X");
        comp.Add(new Leaf("Leaf XA")); // Thêm lá XA vào nhánh X
        comp.Add(new Leaf("Leaf XB")); // Thêm lá XB vào nhánh X

        // Thêm nhánh X vào root
        root.Add(comp);
        root.Add(new Leaf("Leaf C"));  // Thêm lá C vào root

        // Tạo thêm một lá, rồi thêm vào root và sau đó xóa đi
        Leaf leaf = new Leaf("Leaf D");
        root.Add(leaf);
        root.Remove(leaf);

        // Hiển thị toàn bộ cây theo cấu trúc đệ quy
        root.Display(1);

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
