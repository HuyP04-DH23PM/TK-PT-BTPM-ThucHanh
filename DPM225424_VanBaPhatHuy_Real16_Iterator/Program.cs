using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Iterator (Trình lặp) – ví dụ thực tế: duyệt bộ sưu tập với bước nhảy tùy chỉnh
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo bộ sưu tập và thêm phần tử
        Collection collection = new Collection();
        collection[0] = new Item("Item 0");
        collection[1] = new Item("Item 1");
        collection[2] = new Item("Item 2");
        collection[3] = new Item("Item 3");
        collection[4] = new Item("Item 4");
        collection[5] = new Item("Item 5");
        collection[6] = new Item("Item 6");
        collection[7] = new Item("Item 7");
        collection[8] = new Item("Item 8");

        // Tạo Iterator
        Iterator iterator = collection.CreateIterator();

        // Bỏ qua mỗi phần tử kế (bước nhảy = 2)
        iterator.Step = 2;

        Console.WriteLine("Duyệt qua bộ sưu tập:");

        // Duyệt từ phần tử đầu tiên, dừng khi IsDone = true
        for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
        {
            Console.WriteLine(item.Name);
        }

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
