using System;
using System.Text;
using Bridge.Structural;

namespace Bridge.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo bộ điều khiển tưới tiêu trung tâm
            Abstraction controller = new RefinedAbstraction();

            // Gán công nghệ tưới = Nhỏ giọt
            controller.Implementor = new ConcreteImplementorA();
            controller.Operation();  // 💧 Nhỏ giọt

            Console.WriteLine();

            // Đổi công nghệ tưới = Phun mưa
            controller.Implementor = new ConcreteImplementorB();
            controller.Operation();  // 🌦️ Phun mưa

            Console.ReadKey();
        }
    }
}
