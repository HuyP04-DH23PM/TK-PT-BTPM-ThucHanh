
/// <summary>
/// Lớp 'Chatroom' (ConcreteMediator) – quản lý danh bạ và điều phối tin nhắn
/// </summary>
public class Chatroom : AbstractChatroom
{
    // Bảng tra cứu tên → Participant
    private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

    public override void Register(Participant participant)
    {
        // Nếu chưa có trong phòng thì thêm vào
        if (!participants.ContainsValue(participant))
        {
            participants[participant.Name] = participant;
        }
        // Gắn tham chiếu Mediator để Participant có thể gửi/nhận
        participant.Chatroom = this;
    }

    public override void Send(string from, string to, string message)
    {
        // Tìm người nhận theo tên; (mẫu gốc giả định luôn tồn tại)
        Participant participant = participants[to];

        if (participant != null)
        {
            participant.Receive(from, message);   // Chuyển tiếp tin
        }
        // Có thể bổ sung else { Console.WriteLine("Không tìm thấy người nhận..."); }
    }
}
