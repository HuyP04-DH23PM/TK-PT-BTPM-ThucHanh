using System;
using System.Text;

/// <summary>
/// Mẫu thiết kế Memento (Ghi nhớ/Ảnh chụp trạng thái)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Originator o = new Originator();
        o.State = "On";

        // Lưu trạng thái nội bộ (tạo Memento)
        Caretaker c = new Caretaker();
        c.Memento = o.CreateMemento();

        // Tiếp tục thay đổi Originator
        o.State = "Off";

        // Khôi phục trạng thái đã lưu
        o.SetMemento(c.Memento);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
