using System;

// Target: giao diện mới mà hệ thống hiện tại mong muốn
public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("🌿 Yêu cầu đo độ ẩm theo chuẩn hệ thống mới");
    }
}
