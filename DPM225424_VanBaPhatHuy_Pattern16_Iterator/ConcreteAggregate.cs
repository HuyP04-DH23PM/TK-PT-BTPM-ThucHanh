
/// <summary>
/// Lớp ConcreteAggregate – hiện thực bộ sưu tập cụ thể
/// </summary>
public class ConcreteAggregate : Aggregate
{
    // Danh sách phần tử bên trong bộ sưu tập
    List<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    // Thuộc tính: số lượng phần tử
    public int Count
    {
        get { return items.Count; }
    }

    // Chỉ số (Indexer) – dùng Insert để minh họa thêm phần tử tại vị trí
    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}
