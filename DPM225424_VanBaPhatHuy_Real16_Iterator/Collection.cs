
/// <summary>
/// Lớp 'ConcreteAggregate' – hiện thực bộ sưu tập cụ thể
/// </summary>
public class Collection : IAbstractCollection
{
    // Danh sách các Item bên trong bộ sưu tập
    List<Item> items = new List<Item>();

    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }

    // Lấy số lượng phần tử
    public int Count
    {
        get { return items.Count; }
    }

    // Chỉ số (Indexer)
    // LƯU Ý: Setter đang dùng Add(value) → luôn thêm vào cuối danh sách, KHÔNG cài đặt theo chỉ số truyền vào.
    // Mẫu gốc dùng cách này để đơn giản hóa thao tác thêm phần tử theo thứ tự.
    public Item this[int index]
    {
        get { return items[index]; }
        set { items.Add(value); }
    }
}
