/// <summary>
/// Lớp 'Proxy' (Đại diện cho RealSubject, kiểm soát truy cập)
/// </summary>
public class Proxy : Subject
{
    // Tham chiếu đến đối tượng thật
    private RealSubject realSubject;

    public override void Request()
    {
        // Khởi tạo chậm (lazy initialization): chỉ tạo RealSubject khi thật sự cần
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }

        // Ủy quyền gọi phương thức cho đối tượng thật
        realSubject.Request();
    }
}