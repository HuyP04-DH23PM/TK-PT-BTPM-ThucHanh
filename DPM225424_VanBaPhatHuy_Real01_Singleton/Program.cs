using System;
using System.Collections.Generic;

namespace Singleton.RealWorld
{
    // Demo Singleton Pattern trong tình huống thực tế: LoadBalancer
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lấy ra nhiều "thể hiện" LoadBalancer
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Kiểm tra: tất cả đều trỏ đến cùng một instance duy nhất
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // LoadBalancer được dùng để phân phối 15 request đến các server
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            // Dừng màn hình console chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }
}
