
/// <summary>
/// Lớp 'Participant' (AbstractColleague) – mô tả một người dùng trong phòng chat
/// </summary>
public class Participant
{
    // Tham chiếu Mediator (phòng chat)
    Chatroom chatroom;

    // Tên hiển thị của người tham gia
    string name;

    // Khởi tạo với tên
    public Participant(string name)
    {
        this.name = name;
    }

    // Thuộc tính chỉ đọc: Tên người tham gia
    public string Name
    {
        get { return name; }
    }

    // Thuộc tính: tham chiếu đến phòng chat
    public Chatroom Chatroom
    {
        set { chatroom = value; }
        get { return chatroom; }
    }

    // Gửi tin đến một người dùng khác (thông qua Mediator)
    public void Send(string to, string message)
    {
        chatroom.Send(name, to, message);
    }

    // Nhận tin từ một người dùng khác (được Mediator gọi)
    public virtual void Receive(string from, string message)
    {
        Console.WriteLine("{0} -> {1}: '{2}'", from, Name, message);
    }
}
