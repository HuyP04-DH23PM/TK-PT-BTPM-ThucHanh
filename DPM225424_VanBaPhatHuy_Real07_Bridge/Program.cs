using System;
using System.Collections.Generic;

namespace Bridge.RealWorld
{
    // Demo Bridge Design Pattern
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo RefinedAbstraction
            var customers = new Customers();

            // Gán ConcreteImplementor (nguồn dữ liệu cụ thể)
            customers.Data = new CustomersData("Chicago");

            // Dùng bridge để thao tác dữ liệu khách hàng
            customers.Show();   // Hiển thị bản ghi hiện tại
            customers.Next();   // Sang bản ghi kế tiếp
            customers.Show();   // Hiển thị bản ghi hiện tại
            customers.Next();   // Sang bản ghi kế tiếp
            customers.Show();   // Hiển thị bản ghi hiện tại

            customers.Add("Henry Velasquez"); // Thêm khách hàng mới

            customers.ShowAll(); // Hiển thị tất cả khách hàng trong thành phố

            // Dừng console chờ người dùng nhấn phím
            Console.ReadKey();
        }
    }
}
