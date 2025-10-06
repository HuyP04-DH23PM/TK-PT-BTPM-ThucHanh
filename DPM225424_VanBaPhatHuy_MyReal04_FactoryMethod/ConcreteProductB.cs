using System;

// Gói sản phẩm hóa học
class ConcreteProductB : Product
{
    public override string TenGoi => "Gói nông dược hóa học AGU";

    public override void DongGoi()
    {
        Console.WriteLine($"📦 Đang đóng gói: {TenGoi}");
        Console.WriteLine($"   - Phân bón hóa học");
        Console.WriteLine($"   - Thuốc trừ sâu tổng hợp AGU Synth");
    }
}
