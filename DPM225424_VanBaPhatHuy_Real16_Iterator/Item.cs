
/// <summary>
/// Phần tử của bộ sưu tập
/// </summary>
public class Item
{
    string name;

    // Hàm khởi tạo
    public Item(string name)
    {
        this.name = name;
    }

    // Thuộc tính chỉ đọc: Tên phần tử
    public string Name
    {
        get { return name; }
    }
}
