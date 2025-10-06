using System;

/// <summary>
/// 'ConcreteClassA' – MyReal:
/// Quy trình cho ĐƠN HỮU CƠ (phân hữu cơ + thuốc sinh học)
/// </summary>
public class ConcreteClassA : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("🌿 [HỮU CƠ] Bước 1: Kiểm kho & đóng gói chống ẩm (silica + màng PE).");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("🌿 [HỮU CƠ] Bước 2: In hoá đơn VAT 8% & gửi thông báo Zalo/SMS cho khách.");
    }
}
