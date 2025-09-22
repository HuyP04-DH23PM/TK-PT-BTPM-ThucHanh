
/// <summary>
/// Lớp cụ thể 'Categories' – hiện thực thao tác trên danh sách danh mục màu sắc
/// </summary>
public class Categories : DataAccessor
{
    private List<string> categories;

    public override void Connect()
    {
        // Khởi tạo nguồn dữ liệu (ở đây là danh sách trong bộ nhớ)
        categories = new List<string>();
    }

    public override void Select()
    {
        // Đổ dữ liệu mẫu
        categories.Add("Red");
        categories.Add("Green");
        categories.Add("Blue");
        categories.Add("Yellow");
        categories.Add("Purple");
        categories.Add("White");
        categories.Add("Black");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Danh mục (Categories) ---- ");

        // In ra tối đa 'top' phần tử đầu
        for (int i = 0; i < top; i++)
        {
            Console.WriteLine(categories[i]);
        }

        Console.WriteLine();
    }

    public override void Disconnect()
    {
        // Giải phóng/thu dọn dữ liệu
        categories.Clear();
    }
}
