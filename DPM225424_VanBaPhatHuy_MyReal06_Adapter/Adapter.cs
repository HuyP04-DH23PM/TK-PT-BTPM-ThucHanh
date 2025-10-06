using System;

// Adapter: cầu nối giữa hệ thống mới (Target) và thiết bị cũ (Adaptee)
public class Adapter : Target
{
    private Adaptee _legacySensor = new Adaptee();

    // Ghi đè Request() để chuyển đổi lời gọi sang thiết bị cũ
    public override void Request()
    {
        Console.WriteLine("🔄 Adapter đang chuyển đổi yêu cầu...");
        _legacySensor.DoDoAmLegacy();
    }
}
