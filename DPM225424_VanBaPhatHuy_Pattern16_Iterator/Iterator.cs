
/// <summary>
/// Lớp trừu tượng Iterator – giao diện các thao tác duyệt
/// </summary>
public abstract class Iterator
{
    public abstract object First();       // Lấy phần tử đầu tiên
    public abstract object Next();        // Lấy phần tử kế tiếp
    public abstract bool IsDone();        // Đã duyệt xong chưa
    public abstract object CurrentItem(); // Lấy phần tử hiện tại
}
