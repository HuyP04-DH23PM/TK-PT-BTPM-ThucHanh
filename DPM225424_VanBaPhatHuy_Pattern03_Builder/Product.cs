using System;
using System.Collections.Generic;

// 'Product' là lớp đại diện cho sản phẩm cuối cùng
// Các Builder sẽ thêm (Add) các phần vào sản phẩm này
class Product
{
    // Danh sách lưu trữ các phần (Part) của sản phẩm
    private List<string> _parts = new List<string>();

    // Thêm một phần vào sản phẩm
    public void Add(string part)
    {
        _parts.Add(part);
    }

    // Hiển thị toàn bộ các phần đã được thêm vào sản phẩm
    public void Show()
    {
        Console.WriteLine("\nProduct Parts -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
    }
}
