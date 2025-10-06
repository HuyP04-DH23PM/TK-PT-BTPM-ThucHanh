using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Đơn hàng cơ bản
        ConcreteComponent donHangCoBan = new ConcreteComponent();

        // Bọc 1: Đóng gói chống ẩm
        ConcreteDecoratorA dongGoiChongAm = new ConcreteDecoratorA();
        dongGoiChongAm.SetComponent(donHangCoBan);

        // Bọc 2: Giao nhanh trong ngày (bọc ngoài cùng)
        ConcreteDecoratorB giaoNhanh = new ConcreteDecoratorB();
        giaoNhanh.SetComponent(dongGoiChongAm);

        // Thực thi toàn bộ chuỗi trang trí (decorators)
        Console.WriteLine("🌿 Quy trình xử lý đơn hàng:");
        giaoNhanh.Operation();

        Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
