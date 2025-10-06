using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Gốc cây danh mục
        var root = new Composite("Danh mục nông dược AGU");

        // Nhánh: Phân bón
        var fertilizers = new Composite("Phân bón");
        fertilizers.Add(new Leaf("Phân bón hữu cơ AGU"));
        fertilizers.Add(new Leaf("Phân bón hóa học AGU"));

        // Nhánh: Thuốc trừ sâu
        var pesticides = new Composite("Thuốc trừ sâu");
        pesticides.Add(new Leaf("Thuốc sinh học AGU Bio"));
        pesticides.Add(new Leaf("Thuốc trừ sâu tổng hợp AGU Synth"));

        // Nhánh con: Thuốc đặc trị (nằm trong Thuốc trừ sâu)
        var specialty = new Composite("Thuốc đặc trị");
        specialty.Add(new Leaf("Thuốc trừ sâu rầy"));
        specialty.Add(new Leaf("Thuốc trị nấm bệnh"));
        pesticides.Add(specialty);

        // Gắn vào root
        root.Add(fertilizers);
        root.Add(pesticides);

        // Ví dụ thêm rồi xóa một sản phẩm
        var tempLeaf = new Leaf("Thuốc thử nghiệm (tạm)");
        root.Add(tempLeaf);
        root.Remove(tempLeaf);

        Console.WriteLine("🌿 CẤU TRÚC DANH MỤC NÔNG DƯỢC");
        root.Display(1);

        Console.ReadKey();
    }
}
