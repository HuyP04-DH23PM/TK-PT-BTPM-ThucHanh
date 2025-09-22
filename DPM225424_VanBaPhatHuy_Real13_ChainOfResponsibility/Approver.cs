/// <summary>
/// Lớp trừu tượng 'Approver' (Handler) – định nghĩa giao diện xử lý và liên kết đến cấp kế tiếp
/// </summary>
public abstract class Approver
{
    // Cấp phê duyệt kế tiếp trong chuỗi (successor)
    protected Approver successor;

    // Thiết lập cấp kế tiếp
    public void SetSuccessor(Approver successor)
    {
        this.successor = successor;
    }

    // Phương thức trừu tượng: xử lý yêu cầu mua hàng
    public abstract void ProcessRequest(Purchase purchase);
}