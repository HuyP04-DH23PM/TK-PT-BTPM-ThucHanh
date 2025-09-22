
/// <summary>
/// Lớp trừu tượng 'AbstractChatroom' (Mediator) – định nghĩa API đăng ký và chuyển tiếp tin nhắn
/// </summary>
public abstract class AbstractChatroom
{
    public abstract void Register(Participant participant);                   // Đăng ký người tham gia
    public abstract void Send(string from, string to, string message);        // Gửi tin từ 'from' đến 'to'
}
