using System;

// Lớp MainApp: điểm bắt đầu của chương trình (demo Factory Method Pattern)
class MainApp
{
    static void Main()
    {
        // Tạo một mảng chứa các Creator (nhà máy tạo sản phẩm)
        Creator[] creators = new Creator[2];
        creators[0] = new ConcreteCreatorA(); // Nhà máy A
        creators[1] = new ConcreteCreatorB(); // Nhà máy B

        // Duyệt qua từng Creator và tạo sản phẩm tương ứng
        foreach (Creator creator in creators)
        {
            Product product = creator.FactoryMethod(); // Tạo sản phẩm
            Console.WriteLine("Created {0}", product.GetType().Name);
            // In ra tên sản phẩm cụ thể (ConcreteProductA hoặc ConcreteProductB)
        }

        // Dừng màn hình console, chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
