using System;

// Gói sản phẩm hữu cơ
class ConcreteProductA : Product
{
    public override string TenGoi => "Gói nông dược hữu cơ AGU";

    public override void DongGoi()
    {
        Console.WriteLine($"📦 Đang đóng gói: {TenGoi}");
        Console.WriteLine($"   - Phân bón hữu cơ");
        Console.WriteLine($"   - Thuốc sinh học AGU Bio");
    }
}
