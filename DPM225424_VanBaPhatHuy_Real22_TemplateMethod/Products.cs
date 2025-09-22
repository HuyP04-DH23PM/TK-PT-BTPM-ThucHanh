
/// <summary>
/// Lớp cụ thể 'Products' – hiện thực thao tác trên danh sách sản phẩm
/// </summary>
public class Products : DataAccessor
{
    private List<string> products;

    public override void Connect()
    {
        // Khởi tạo nguồn dữ liệu (ở đây là danh sách trong bộ nhớ)
        products = new List<string>();
    }

    public override void Select()
    {
        // Đổ dữ liệu mẫu
        products.Add("Car");
        products.Add("Bike");
        products.Add("Boat");
        products.Add("Truck");
        products.Add("Moped");
        products.Add("Rollerskate");
        products.Add("Stroller");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Sản phẩm (Products) ---- ");

        // In ra tối đa 'top' phần tử đầu
        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(products[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        // Giải phóng/thu dọn dữ liệu
        products.Clear();
    }
}
