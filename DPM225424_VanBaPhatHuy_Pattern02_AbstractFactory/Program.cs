using System;
namespace DoFactory.GangOfFour.Abstract.Structural
{
    class MainApp
    {
        public static void Main()
        {
            // Tạo factory cụ thể số 1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run(); // Client1 chạy với ProductA1 và ProductB1

            // Tạo factory cụ thể số 2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run(); // Client2 chạy với ProductA2 và ProductB2

            // Dừng màn hình console chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }
}
