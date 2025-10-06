using System;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// Strategy Pattern – MyReal: thay đổi CHIẾN LƯỢC sắp xếp danh sách sản phẩm nông dược
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Danh sách sản phẩm nông dược (ví dụ)
        var products = new SortedList();
        products.Add("Phân bón hữu cơ AGU - 25kg");
        products.Add("Thuốc sinh học AGU Bio - 1L");
        products.Add("Phân bón hoá học AGU - 25kg");
        products.Add("Thuốc trừ sâu tổng hợp AGU Synth - 1L");
        products.Add("Hạt giống lúa OM18 - 5kg");

        // Áp dụng QuickSort (thật)
        products.SetSortStrategy(new QuickSort());
        products.Sort();

        // Áp dụng ShellSort (minh hoạ)
        products.SetSortStrategy(new ShellSort());
        products.Sort();

        // Áp dụng MergeSort (minh hoạ)
        products.SetSortStrategy(new MergeSort());
        products.Sort();

        Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
