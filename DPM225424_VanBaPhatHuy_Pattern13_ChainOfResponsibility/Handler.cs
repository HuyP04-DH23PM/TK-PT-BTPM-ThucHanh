
/// <summary>
/// Lớp trừu tượng Handler – định nghĩa giao diện xử lý và liên kết đến Handler kế tiếp
/// </summary>
public abstract class Handler
{
    // Tham chiếu đến Handler kế tiếp trong chuỗi
    protected Handler successor;

    // Thiết lập Handler kế tiếp
    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    // Phương thức trừu tượng xử lý yêu cầu
    public abstract void HandleRequest(int request);
}