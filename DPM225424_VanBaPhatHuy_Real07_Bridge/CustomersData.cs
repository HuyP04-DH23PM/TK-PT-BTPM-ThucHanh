using System;
using System.Collections.Generic;

// 'CustomersData' là một ConcreteImplementor trong Bridge Pattern
// Nó kế thừa từ DataObject và cài đặt chi tiết cách lưu trữ & xử lý dữ liệu khách hàng
public class CustomersData : DataObject
{
    private readonly List<string> customers = new List<string>(); // danh sách khách hàng
    private int current = 0;                                      // chỉ số khách hàng hiện tại
    private string city;                                          // thành phố quản lý khách hàng

    // Constructor: khởi tạo với tên thành phố và thêm dữ liệu giả định
    public CustomersData(string city)
    {
        this.city = city;

        // Tải dữ liệu từ "cơ sở dữ liệu" (ở đây mô phỏng bằng danh sách cứng)
        customers.Add("Jim Jones");
        customers.Add("Samual Jackson");
        customers.Add("Allen Good");
        customers.Add("Ann Stills");
        customers.Add("Lisa Giolani");
    }

    // Chuyển đến bản ghi kế tiếp
    public override void NextRecord()
    {
        if (current <= customers.Count - 1)
        {
            current++;
        }
    }

    // Quay về bản ghi trước đó
    public override void PriorRecord()
    {
        if (current > 0)
        {
            current--;
        }
    }

    // Thêm một khách hàng mới
    public override void AddRecord(string customer)
    {
        customers.Add(customer);
    }

    // Xóa một khách hàng
    public override void DeleteRecord(string customer)
    {
        customers.Remove(customer);
    }

    // Lấy khách hàng hiện tại
    public override string GetCurrentRecord()
    {
        return customers[current];
    }

    // Hiển thị khách hàng hiện tại
    public override void ShowRecord()
    {
        Console.WriteLine(customers[current]);
    }

    // Hiển thị toàn bộ khách hàng
    public override void ShowAllRecords()
    {
        Console.WriteLine("Customer City: " + city);

        foreach (string customer in customers)
        {
            Console.WriteLine(" " + customer);
        }
    }
}
