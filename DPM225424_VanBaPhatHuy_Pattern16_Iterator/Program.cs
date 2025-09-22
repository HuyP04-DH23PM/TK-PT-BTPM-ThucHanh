using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Iterator (Trình lặp) – tách cách duyệt khỏi cấu trúc lưu trữ
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo bộ sưu tập (Aggregate) cụ thể và thêm phần tử
        ConcreteAggregate a = new ConcreteAggregate();
        a[0] = "Mục A";
        a[1] = "Mục B";
        a[2] = "Mục C";
        a[3] = "Mục D";

        // Tạo Iterator và truyền vào bộ sưu tập cần duyệt
        Iterator i = a.CreateIterator();

        Console.WriteLine("Duyệt qua bộ sưu tập:");

        // Lấy phần tử đầu tiên
        object item = i.First();

        // Lặp cho đến khi hết phần tử (Next trả về null khi vượt cuối)
        while (item != null)
        {
            Console.WriteLine(item);
            item = i.Next();
        }

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
