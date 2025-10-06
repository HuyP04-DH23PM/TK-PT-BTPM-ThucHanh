using System;

// 'ConcreteComponent' (MyReal): ĐƠN HÀNG cơ bản của cửa hàng nông dược
// Chưa có dịch vụ cộng thêm (đóng gói, giao nhanh,...)
public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("🧾 Tạo đơn hàng nông dược cơ bản:");
        Console.WriteLine("   • Phân bón hữu cơ AGU");
        Console.WriteLine("   • Thuốc sinh học AGU Bio");
    }
}
