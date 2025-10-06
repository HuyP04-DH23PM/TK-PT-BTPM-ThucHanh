using System;
using System.Text;

/// <summary>
/// Receiver – MyReal: chứa nghiệp vụ thật để xử lý đơn hàng
/// </summary>
public class Receiver
{
    public void Action(string orderId)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine($"🧾 Bắt đầu xử lý đơn: {orderId} ({DateTime.Now:HH:mm dd/MM/yyyy})");

        Console.WriteLine("📦 Đóng gói chống ẩm (silica + màng PE)...");
        Console.WriteLine("📊 Cập nhật tồn kho: - Phân hữu cơ AGU x2, - Thuốc sinh học AGU Bio x1");
        Console.WriteLine("🧾 In hoá đơn VAT 8% và phiếu giao hàng...");
        Console.WriteLine("🔔 Gửi thông báo Zalo/SMS cho khách: đơn đã sẵn sàng giao.");

        Console.WriteLine("✅ Hoàn tất xử lý đơn.");
    }
}
