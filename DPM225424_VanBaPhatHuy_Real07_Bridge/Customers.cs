using System;

// 'Customers' là lớp Abstraction mở rộng (RefinedAbstraction)
// Nó kế thừa từ CustomersBase và có thể thay đổi cách hiển thị
public class Customers : CustomersBase
{
    // Ghi đè phương thức ShowAll để bổ sung thêm xử lý khi hiển thị
    public override void ShowAll()
    {
        // In ra đường phân cách trước khi hiển thị danh sách
        Console.WriteLine();
        Console.WriteLine("------------------------");

        // Gọi phương thức gốc trong CustomersBase (sẽ hiển thị danh sách khách hàng)
        base.ShowAll();

        // In ra đường phân cách sau khi hiển thị
        Console.WriteLine("------------------------");
    }
}
