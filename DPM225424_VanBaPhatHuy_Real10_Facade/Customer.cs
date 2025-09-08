public class Customer
{
    private string name; // Tên khách hàng

    // Hàm khởi tạo: gán tên cho khách hàng
    public Customer(string name)
    {
        this.name = name;
    }

    // Thuộc tính chỉ đọc: trả về tên khách hàng
    public string Name
    {
        get { return name; }
    }
}
