using System;
using System.Text;

namespace MyReal.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Lấy thể hiện duy nhất của AppConfig (Singleton)
            var config1 = AppConfig.Instance;
            var config2 = AppConfig.Instance;

            if (ReferenceEquals(config1, config2))
            {
                Console.WriteLine("✅ Cả hai biến đều trỏ tới cùng một Singleton (AppConfig).");
            }

            // In thông tin cấu hình hiện tại
            Console.WriteLine("\n=== Thông tin cấu hình hệ thống ===");
            Console.WriteLine($"Tên cửa hàng : {config1.StoreName}");
            Console.WriteLine($"Địa chỉ      : {config1.Address}");
            Console.WriteLine($"Thuế (%)     : {config1.TaxRate * 100}");
            Console.WriteLine($"Kết nối DB   : {config1.ConnectionString}");

            // Ví dụ tính giá có thuế để thấy config dùng chung
            decimal subtotal = 1000000m;
            decimal tax = subtotal * config1.TaxRate;
            decimal total = subtotal + tax;

            Console.WriteLine("\n=== Demo tính giá ===");
            Console.WriteLine($"Tạm tính : {subtotal:N0} đ");
            Console.WriteLine($"Thuế     : {tax:N0} đ");
            Console.WriteLine($"Tổng     : {total:N0} đ");

            Console.ReadKey();
        }
    }
}
