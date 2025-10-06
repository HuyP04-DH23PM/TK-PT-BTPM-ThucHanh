using System;

/// <summary>
/// 'ConcreteClassB' – MyReal:
/// Quy trình cho ĐƠN HÓA HỌC (phân/thuốc tổng hợp – yêu cầu an toàn)
/// </summary>
public class ConcreteClassB : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("🧪 [HÓA HỌC] Bước 1: Kiểm tra MSDS, bao gói an toàn & dán tem cảnh báo.");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("🧪 [HÓA HỌC] Bước 2: Tạo vận đơn GHN nội tỉnh & thông báo thời gian giao.");
    }
}
