using System;
using System.Collections.Generic;

namespace Singleton.RealWorld
{
    // 'LoadBalancer' là lớp Singleton
    // Nó quản lý danh sách server và phân phối request đến ngẫu nhiên một server
    public class LoadBalancer
    {
        // Biến static giữ thể hiện duy nhất của LoadBalancer
        static LoadBalancer instance;

        // Danh sách server
        List<string> servers = new List<string>();

        // Biến random để chọn server ngẫu nhiên
        Random random = new Random();

        // Đối tượng khóa để hỗ trợ thread-safe (đa luồng)
        private static object locker = new object();

        // Constructor để protected → ngăn không cho tạo đối tượng trực tiếp từ bên ngoài
        protected LoadBalancer()
        {
            // Khởi tạo danh sách server
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        // Phương thức static để lấy thể hiện duy nhất của LoadBalancer
        public static LoadBalancer GetLoadBalancer()
        {
            // Dùng kỹ thuật "Double Checked Locking"
            // để vừa an toàn trong môi trường đa luồng, vừa tránh lock không cần thiết
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }

        // Thuộc tính: chọn ngẫu nhiên một server từ danh sách để phân phối request
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
    }
}
