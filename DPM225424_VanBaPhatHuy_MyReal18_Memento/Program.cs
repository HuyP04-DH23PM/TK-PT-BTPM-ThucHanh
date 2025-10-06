using System;
using System.Text;

/// <summary>
/// Memento Pattern – MyReal: Lưu/khôi phục trạng thái ĐƠN HÀNG nông dược
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Khởi tạo đơn hàng (Originator)
        Originator o = new Originator();
        o.State = "AGU-ORDER-001 | Soạn hàng: Phân hữu cơ x2; AGU Bio x1";

        // Lưu trạng thái nội bộ (tạo Memento) trước khi thay đổi lớn
        Caretaker c = new Caretaker();
        c.Memento = o.CreateMemento();

        // Thay đổi tiếp (giả lập sai sót/huỷ nhầm)
        o.State = "AGU-ORDER-001 | ĐÃ HUỶ (khách đổi ý)";

        // Khôi phục về trạng thái đã lưu (undo)
        o.SetMemento(c.Memento);

        Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
