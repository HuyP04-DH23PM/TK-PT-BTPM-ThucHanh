using System;
using System.Text;

class MainApp
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Danh sách các "nhà máy" đóng gói
        Creator[] creators = new Creator[2];
        creators[0] = new ConcreteCreatorA(); // Nhà máy hữu cơ
        creators[1] = new ConcreteCreatorB(); // Nhà máy hóa học

        foreach (Creator creator in creators)
        {
            // Tạo ra gói sản phẩm từ từng nhà máy
            Product goi = creator.FactoryMethod();
            goi.DongGoi(); // Thực hiện đóng gói thật
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
