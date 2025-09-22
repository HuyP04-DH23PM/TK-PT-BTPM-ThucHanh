
/// <summary>
/// Lớp ConcreteIterator – triển khai cách duyệt cho ConcreteAggregate
/// </summary>
public class ConcreteIterator : Iterator
{
    // Tham chiếu đến bộ sưu tập cần duyệt
    ConcreteAggregate aggregate;

    // Con trỏ vị trí hiện tại trong danh sách
    int current = 0;

    // Hàm khởi tạo – nhận bộ sưu tập để duyệt
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    // Trả về phần tử đầu tiên
    public override object First()
    {
        return aggregate[0];
    }

    // Trả về phần tử kế tiếp (hoặc null nếu đã hết)
    public override object Next()
    {
        object ret = null;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }
        return ret;
    }

    // Trả về phần tử hiện tại
    public override object CurrentItem()
    {
        return aggregate[current];
    }

    // Cho biết đã duyệt xong chưa
    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}
