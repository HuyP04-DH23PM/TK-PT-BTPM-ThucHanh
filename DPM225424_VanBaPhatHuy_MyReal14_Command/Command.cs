

/// <summary>
/// Lớp trừu tượng Command – MyReal:
/// Đại diện một lệnh thao tác trên ĐƠN HÀNG nông dược (đóng gói, cập nhật kho, thông báo…)
/// </summary>
public abstract class Command
{
    // Đối tượng thực thi thực sự (Receiver): nghiệp vụ kho/đơn hàng
    protected Receiver receiver;

    protected Command(Receiver receiver)
    {
        this.receiver = receiver;
    }

    // Thực thi lệnh
    public abstract void Execute();
}

