
using System.Text;

/// <summary>
/// Chiến lược cụ thể: MergeSort (minh họa – chưa hiện thực thuật toán thật)
/// </summary>
public class MergeSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // list.MergeSort();  chưa cài đặt
        Console.WriteLine("Đã sắp xếp (mô phỏng) bằng MergeSort");
    }
}
