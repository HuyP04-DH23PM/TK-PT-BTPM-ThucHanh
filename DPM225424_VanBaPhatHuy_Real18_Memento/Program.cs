using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế Memento (Ghi nhớ/Ảnh chụp trạng thái) – ví dụ thực tế: lưu/khôi phục hồ sơ khách hàng tiềm năng
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        SalesProspect s = new SalesProspect();
        s.Name = "Capheny Vahein Helen Goverra Omega";
        s.Phone = "(412) 256-0990";
        s.Budget = 25000.0;

        // Lưu trạng thái nội bộ (tạo Memento và cất tại Caretaker)
        ProspectMemory m = new ProspectMemory();
        m.Memento = s.SaveMemento();

        // Tiếp tục thay đổi trạng thái của Originator
        s.Name = "Leo Welch";
        s.Phone = "(310) 209-7111";
        s.Budget = 1000000.0;

        // Khôi phục trạng thái đã lưu trước đó
        s.RestoreMemento(m.Memento);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
