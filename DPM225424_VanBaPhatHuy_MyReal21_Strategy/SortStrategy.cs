using System;
using System.Collections.Generic;

/// <summary>
/// 'SortStrategy' – MyReal:
/// Giao diện các chiến lược sắp xếp danh sách SẢN PHẨM nông dược.
/// </summary>
public abstract class SortStrategy
{
    public abstract void Sort(List<string> list);
}
