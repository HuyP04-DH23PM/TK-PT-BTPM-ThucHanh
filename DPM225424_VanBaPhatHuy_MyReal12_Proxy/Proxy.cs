using System;

/// <summary>
/// 'Proxy' - kiểm soát truy cập + khởi tạo chậm dịch vụ tồn kho thật
/// </summary>
public class Proxy : Subject
{
    private RealSubject realSubject;               // đối tượng thật
    private const string VALID_KEY = "AGU-KEY-2025";

    // API key để ủy quyền
    public string ApiKey { get; set; } = string.Empty;

    public override void Request()
    {
        // Protection Proxy: kiểm tra quyền
        if (ApiKey != VALID_KEY)
        {
            Console.WriteLine("❌ Truy cập bị từ chối: API key không hợp lệ.");
            return;
        }

        Console.WriteLine("🔐 Kiểm tra quyền hợp lệ. Cho phép truy cập dịch vụ kho...");

        // Virtual Proxy: khởi tạo chậm
        if (realSubject == null)
        {
            Console.WriteLine("🚀 Khởi tạo kết nối dịch vụ tồn kho (lazy init)...");
            realSubject = new RealSubject();
        }

        // Ủy quyền gọi thực thi
        realSubject.Request();

        // Có thể bổ sung logging / rate-limit tại đây
        Console.WriteLine("🧾 Log: truy cập dịch vụ kho thành công.");
    }
}
