using System;
using System.Text;

/// <summary>
/// 'RealSubject' - dịch vụ tồn kho thật (giả lập: thao tác nặng/đắt tiền)
/// </summary>
public class RealSubject : Subject
{
    public override void Request()
    {
        // (Nếu Program đã set UTF-8 thì không bắt buộc dòng dưới)
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("📡 [Kho] Truy xuất tồn kho trực tiếp...");
        Console.WriteLine("   • Phân bón hữu cơ AGU: 120 bao (25kg)");
        Console.WriteLine("   • Phân bón hoá học AGU: 85 bao (25kg)");
        Console.WriteLine("   • Thuốc sinh học AGU Bio: 60 chai (1L)");
        Console.WriteLine("   • Thuốc trừ sâu tổng hợp AGU Synth: 95 chai (1L)");
    }
}
