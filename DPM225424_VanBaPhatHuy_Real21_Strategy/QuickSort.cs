
/// <summary>
/// Chiến lược cụ thể: QuickSort
/// </summary>
public class QuickSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        // Dùng Sort() có sẵn của .NET (mặc định dùng thuật toán tối ưu, thường là QuickSort/Timsort tùy phiên bản)
        list.Sort();  // Mặc định là QuickSort (mang tính minh họa)
        Console.WriteLine("Đã sắp xếp bằng QuickSort");
    }
}
