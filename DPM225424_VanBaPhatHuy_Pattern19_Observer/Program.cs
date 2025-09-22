using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Observer (Quan sát) – đối tượng Subject thông báo cho các Observer khi trạng thái thay đổi
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Cấu hình mẫu Observer
        ConcreteSubject s = new ConcreteSubject();

        // Đăng ký (attach) các observer
        s.Attach(new ConcreteObserver(s, "X"));
        s.Attach(new ConcreteObserver(s, "Y"));
        s.Attach(new ConcreteObserver(s, "Z"));

        // Thay đổi trạng thái của Subject và thông báo cho tất cả Observer
        s.SubjectState = "ABC";
        s.Notify();

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
