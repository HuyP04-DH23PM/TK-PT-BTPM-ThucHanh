
/// <summary>
/// Lớp 'ConcreteIterator' – triển khai cách duyệt cho Collection
/// </summary>
public class Iterator : IAbstractIterator
{
    // Tham chiếu đến bộ sưu tập cần duyệt
    Collection collection;

    // Vị trí hiện tại trong bộ sưu tập
    int current = 0;

    // Bước nhảy khi duyệt (mặc định = 1)
    int step = 1;

    // Hàm khởi tạo
    public Iterator(Collection collection)
    {
        this.collection = collection;
    }

    // Lấy phần tử đầu tiên và đặt con trỏ về 0
    public Item First()
    {
        current = 0;
        return collection[current] as Item;
    }

    // Lấy phần tử kế tiếp theo bước nhảy; trả về null nếu đã vượt cuối
    public Item Next()
    {
        current += step;
        if (!IsDone)
            return collection[current] as Item;
        else
            return null;
    }

    // Lấy/đặt bước nhảy (ví dụ: 2 để bỏ qua 1 phần tử)
    public int Step
    {
        get { return step; }
        set { step = value; }
    }

    // Lấy phần tử hiện tại
    public Item CurrentItem
    {
        get { return collection[current] as Item; }
    }

    // Kiểm tra đã duyệt xong chưa (vượt qua phần tử cuối)
    public bool IsDone
    {
        get { return current >= collection.Count; }
    }
}
