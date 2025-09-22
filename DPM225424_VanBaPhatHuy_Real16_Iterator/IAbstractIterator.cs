
/// <summary>
/// Giao diện 'Iterator' – định nghĩa các thao tác duyệt
/// </summary>
public interface IAbstractIterator
{
    Item First();          // Lấy phần tử đầu tiên
    Item Next();           // Lấy phần tử kế tiếp (theo Step)
    bool IsDone { get; }   // Đã duyệt xong chưa
    Item CurrentItem { get; } // Phần tử hiện tại
}
