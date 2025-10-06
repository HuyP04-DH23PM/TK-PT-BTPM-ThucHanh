using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 'SortedList' – MyReal:
/// Giữ danh sách SẢN PHẨM và uỷ quyền sắp xếp cho chiến lược hiện tại.
/// </summary>
public class SortedList
{
    private readonly List<string> list = new List<string>();
    private SortStrategy sortstrategy;

    public void SetSortStrategy(SortStrategy sortstrategy)
    {
        this.sortstrategy = sortstrategy;
    }

    public void Add(string name)
    {
        list.Add(name);
    }

    public void Sort()
    {
        if (sortstrategy == null)
        {
            Console.WriteLine("⚠️  Chưa chọn chiến lược sắp xếp.");
            return;
        }

        sortstrategy.Sort(list);

        Console.WriteLine("📋 Kết quả sau sắp xếp:");
        foreach (var name in list)
        {
            Console.WriteLine(" • " + name);
        }
        Console.WriteLine();
    }
}
