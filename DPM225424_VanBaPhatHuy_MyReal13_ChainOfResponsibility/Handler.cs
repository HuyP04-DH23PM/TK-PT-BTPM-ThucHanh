/// <summary>
/// Lớp trừu tượng Handler – khai báo xử lý & liên kết Handler kế tiếp
/// (MyReal: mỗi Handler là một cấp duyệt chiết khấu)
/// </summary>
public abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request); // request = % chiết khấu
}
