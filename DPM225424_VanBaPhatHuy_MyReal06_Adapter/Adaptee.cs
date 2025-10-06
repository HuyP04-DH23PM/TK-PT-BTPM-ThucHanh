using System;

// Adaptee: hệ thống đo độ ẩm cũ, không tương thích với chuẩn mới
public class Adaptee
{
    // Phương thức cũ, không trùng tên/chuẩn với Target
    public void DoDoAmLegacy()
    {
        Console.WriteLine("🌡️ [Thiết bị cũ] Đo độ ẩm đất bằng cảm biến analog...");
    }
}
