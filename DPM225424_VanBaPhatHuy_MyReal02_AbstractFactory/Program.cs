using System;
using System.Text;

namespace MyReal.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo nhà máy sản xuất nông dược theo hướng hữu cơ
            AbstractFactory organicFactory = new ConcreteFactory1();
            Client client1 = new Client(organicFactory);
            client1.Run();

            // Tạo nhà máy sản xuất nông dược theo hướng hóa học
            AbstractFactory chemicalFactory = new ConcreteFactory2();
            Client client2 = new Client(chemicalFactory);
            client2.Run();

            Console.ReadKey();
        }
    }
}
