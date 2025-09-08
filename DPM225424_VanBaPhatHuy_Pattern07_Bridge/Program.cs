using System;

namespace Bridge.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo Abstraction (ở đây dùng RefinedAbstraction)
            Abstraction ab = new RefinedAbstraction();

            // Gán Implementor = ConcreteImplementorA và gọi Operation()
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation(); // Kết quả: "ConcreteImplementorA Operation"

            // Đổi Implementor = ConcreteImplementorB và gọi lại Operation()
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation(); // Kết quả: "ConcreteImplementorB Operation"

            // Dừng console chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }
}
