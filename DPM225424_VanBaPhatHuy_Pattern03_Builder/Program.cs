using System;

// Lớp MainApp: điểm bắt đầu của chương trình (demo Builder Pattern)
public class MainApp
{
    public static void Main()
    {
        // Tạo Director và các Builder cụ thể
        Director director = new Director();
        Builder b1 = new ConcreteBuilder1();
        Builder b2 = new ConcreteBuilder2();

        // Xây dựng sản phẩm 1 bằng ConcreteBuilder1
        director.Construct(b1);       // Gọi các bước build (PartA, PartB)
        Product p1 = b1.GetResult();  // Lấy sản phẩm đã build xong
        p1.Show();                    // Hiển thị sản phẩm

        // Xây dựng sản phẩm 2 bằng ConcreteBuilder2
        director.Construct(b2);
        Product p2 = b2.GetResult();
        p2.Show();

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
