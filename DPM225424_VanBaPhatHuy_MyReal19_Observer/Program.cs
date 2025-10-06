using System;
using System.Text;

/// <summary>
/// Observer Pattern – MyReal: Subject phát thông báo về TRẠNG THÁI ĐƠN HÀNG
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Trung tâm thông báo (đơn hàng)
        ConcreteSubject s = new ConcreteSubject();

        // Đăng ký các "kênh nhận" thông báo
        s.Attach(new ConcreteObserver(s, "ZaloBot"));
        s.Attach(new ConcreteObserver(s, "Kho"));
        s.Attach(new ConcreteObserver(s, "KếToán"));

        // 1) Khách thanh toán
        s.SubjectState = "AGU-ORDER-001 | Khách đã THANH TOÁN (1.200.000đ, VAT 8%)";
        s.Notify();

        // 2) Tạo vận đơn
        s.SubjectState = "AGU-ORDER-001 | ĐÃ TẠO VẬN ĐƠN GHN: LX-2025-001 (giao trong ngày)";
        s.Notify();

        // 3) Cập nhật kho
        s.SubjectState = "AGU-ORDER-001 | KHO đã trừ: Hữu cơ x2, Bio x1 — còn đủ tồn";
        s.Notify();

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
