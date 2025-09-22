using System;
using System.Collections.Generic;

/// <summary>
/// Mẫu thiết kế Strategy (Chiến lược) – thay đổi thuật toán sắp xếp lúc chạy
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Sử dụng cùng một ngữ cảnh với các chiến lược khác nhau
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

        // Áp dụng ShellSort (ví dụ minh họa, chưa cài đặt thật)
        studentRecords.SetSortStrategy(new ShellSort());
        studentRecords.Sort();

        // Áp dụng MergeSort (ví dụ minh họa, chưa cài đặt thật)
        studentRecords.SetSortStrategy(new MergeSort());
        studentRecords.Sort();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
