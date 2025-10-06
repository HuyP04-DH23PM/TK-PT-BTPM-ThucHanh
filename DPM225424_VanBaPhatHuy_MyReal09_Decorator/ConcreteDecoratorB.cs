using System;

// 'ConcreteDecoratorB' (MyReal): Thêm dịch vụ GIAO NHANH TRONG NGÀY + thông báo khách
public class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();     // chạy các bước trước
        AddedBehavior();      // logic thêm (gửi thông báo)
        Console.WriteLine("⚡ Thêm dịch vụ: Giao nhanh trong ngày (ưu tiên xử lý)");
    }

    void AddedBehavior()
    {
        Console.WriteLine("🔔 Thông báo khách hàng: đơn hàng đã sẵn sàng để giao nhanh.");
    }
}
