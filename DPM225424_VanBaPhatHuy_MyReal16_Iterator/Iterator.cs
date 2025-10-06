/// <summary>
/// Iterator – MyReal: giao diện cách duyệt qua các mục đơn hàng
/// </summary>
public abstract class Iterator
{
    public abstract object First();       // Lấy mục đầu tiên
    public abstract object Next();        // Lấy mục kế tiếp (null nếu hết)
    public abstract bool IsDone();        // Đã duyệt xong chưa
    public abstract object CurrentItem(); // Mục hiện tại
}
