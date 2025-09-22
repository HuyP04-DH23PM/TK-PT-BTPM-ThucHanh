using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Strategy (Chiến lược) – thay đổi thuật toán sắp xếp lúc chạy
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Hai ngữ cảnh dùng các chiến lược khác nhau (thực tế: dùng chung một ngữ cảnh đổi chiến lược)
        SortedList studentRecords = new SortedList();

        // Thêm dữ liệu mẫu
        studentRecords.Add("Samual");
        studentRecords.Add("Jimmy");
        studentRecords.Add("Sandra");
        studentRecords.Add("Vivek");
        studentRecords.Add("Anna");

        // Áp dụng QuickSort
        studentRecords.SetSortStrategy(new QuickSort());
        studentRecords.Sort();

        // Áp dụng ShellSort (minh họa, chưa cài đặt thuật toán thật)
        studentRecords.SetSortStrategy(new ShellSort());
        studentRecords.Sort();

        // Áp dụng MergeSort (minh họa, chưa cài đặt thuật toán thật)
        studentRecords.SetSortStrategy(new MergeSort());
        studentRecords.Sort();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
