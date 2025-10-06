using System;
using System.Text;

/// <summary>
/// Iterator Pattern – MyReal: duyệt các mục trong ĐƠN HÀNG nông dược
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo "đơn hàng" với các mục thực tế
        var a = new ConcreteAggregate();
        a[0] = "Phân bón hữu cơ AGU x2 bao (25kg)";
        a[1] = "Phân bón hoá học AGU x1 bao (25kg)";
        a[2] = "Thuốc sinh học AGU Bio x3 chai (1L)";
        a[3] = "Thuốc trừ sâu tổng hợp AGU Synth x2 chai (1L)";

        // Tạo Iterator để duyệt các mục
        Iterator i = a.CreateIterator();

        Console.WriteLine("🌿 Duyệt qua các mục trong đơn hàng AGU-ORDER-001:\n");

        // Lấy mục đầu tiên
        object item = i.First();

        // Lặp cho đến khi hết (Next trả về null khi vượt cuối)
        while (item != null)
        {
            Console.WriteLine("• " + item);
            item = i.Next();
        }

        Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
