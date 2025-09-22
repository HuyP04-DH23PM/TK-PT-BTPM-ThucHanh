using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Mẫu thiết kế Mediator (Trung gian) – ví dụ thực tế: phòng chat điều phối tin nhắn giữa các người tham gia
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo phòng chat (Mediator cụ thể)
        Chatroom chatroom = new Chatroom();

        // Tạo các người tham gia (Colleague) và đăng ký vào phòng chat
        Participant George = new Beatle("George");
        Participant Paul = new Beatle("Paul");
        Participant Ringo = new Beatle("Ringo");
        Participant John = new Beatle("John");
        Participant Yoko = new NonBeatle("Yoko");

        chatroom.Register(George);
        chatroom.Register(Paul);
        chatroom.Register(Ringo);
        chatroom.Register(John);
        chatroom.Register(Yoko);

        // Các thành viên gửi tin nhắn (qua Mediator, không gửi trực tiếp)
        Yoko.Send("John", "Hi John!");
        Paul.Send("Ringo", "All you need is love");
        Ringo.Send("George", "My sweet Lord");
        Paul.Send("John", "Can't buy me love");
        John.Send("Yoko", "My sweet love");

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
