using System;

/// <summary>
/// Trạng thái cụ thể A: MỞ BÁN (đang nhận đơn)
/// </summary>
public class ConcreteStateA : State
{
    public override string Ten => "MỞ BÁN";

    public override void Handle(Context context)
    {
        Console.WriteLine("🟢 [MỞ BÁN] Tiếp nhận đơn mới, in hoá đơn, thông báo kho soạn hàng...");
        // Sau một chu kỳ, cửa hàng tạm dừng để kiểm kho/đổi ca
        Console.WriteLine("↪️  Chuyển sang TẠM DỪNG để kiểm kho/đổi ca.");
        context.State = new ConcreteStateB();
    }
}
