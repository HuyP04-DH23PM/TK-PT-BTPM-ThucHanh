using System;

/// <summary>
/// Trạng thái cụ thể B: TẠM DỪNG (kiểm kho/đổi ca)
/// </summary>
public class ConcreteStateB : State
{
    public override string Ten => "TẠM DỪNG";

    public override void Handle(Context context)
    {
        Console.WriteLine("🟡 [TẠM DỪNG] Kho kiểm đếm tồn, cập nhật số liệu, chuẩn bị ca mới...");
        // Hoàn tất kiểm kho → mở bán lại
        Console.WriteLine("↪️  Hoàn tất kiểm kho. Chuyển sang MỞ BÁN.");
        context.State = new ConcreteStateA();
    }
}
