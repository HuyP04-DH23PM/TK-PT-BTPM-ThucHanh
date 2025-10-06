using System;

// 'ConcreteDecoratorA' (MyReal): Thêm dịch vụ ĐÓNG GÓI CHỐNG ẨM (silica gel, màng PE)
public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation(); // chạy đơn hàng/bọc trước đó
        Console.WriteLine("📦 Thêm dịch vụ: Đóng gói chống ẩm (silica + màng PE)");
    }
}
