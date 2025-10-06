
/// <summary>
/// ConcreteCommand – MyReal:
/// Lệnh "XỬ LÝ ĐƠN HÀNG" gồm: đóng gói chống ẩm → cập nhật tồn kho → gửi thông báo
/// </summary>
public class ConcreteCommand : Command
{
    // (tuỳ chọn) bạn có thể truyền mã đơn nếu muốn mở rộng
    private readonly string orderId;

    public ConcreteCommand(Receiver receiver, string orderId = "AGU-ORDER-001")
        : base(receiver)
    {
        this.orderId = orderId;
    }

    public override void Execute()
    {
        receiver.Action(orderId);
    }
}
