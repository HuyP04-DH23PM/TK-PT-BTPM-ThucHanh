using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Chiến lược cụ thể: QuickSort (dùng Sort() có sẵn của .NET)
/// </summary>
public class QuickSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        Console.OutputEncoding = Encoding.UTF8;
        list.Sort(); // sắp xếp A→Z theo tên sản phẩm
        Console.WriteLine("✅ Đã sắp xếp danh sách sản phẩm bằng QuickSort (A→Z).");
    }
}
