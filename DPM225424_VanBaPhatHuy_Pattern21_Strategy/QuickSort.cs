
using System.Text;

/// <summary>
/// Chiến lược cụ thể: QuickSort
/// </summary>
public class QuickSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Dùng phương thức Sort() có sẵn (nội bộ .NET cài đặt thuật toán thích hợp)
        list.Sort();
        Console.WriteLine("Đã sắp xếp bằng QuickSort");
    }
}
