using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Template (Khuôn mẫu) – định nghĩa khung quy trình và cho phép lớp con hiện thực các bước cụ thể
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo đối tượng truy cập dữ liệu cụ thể và chạy theo khuôn mẫu
        DataAccessor categories = new Categories();
        categories.Run(5); // xử lý 5 mục đầu

        DataAccessor products = new Products();
        products.Run(3);   // xử lý 3 mục đầu

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
