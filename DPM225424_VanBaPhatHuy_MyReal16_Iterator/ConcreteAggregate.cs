using System.Collections.Generic;

/// <summary>
/// ConcreteAggregate – MyReal: danh sách mục đơn (chuỗi mô tả sản phẩm + số lượng)
/// </summary>
public class ConcreteAggregate : Aggregate
{
    private readonly List<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    // Số lượng mục trong đơn
    public int Count => items.Count;

    // Indexer (dùng Insert để minh hoạ thêm mục tại vị trí)
    public object this[int index]
    {
        get => items[index];
        set => items.Insert(index, value);
    }
}
