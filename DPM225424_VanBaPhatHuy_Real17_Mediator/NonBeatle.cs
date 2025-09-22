
/// <summary>
/// Lớp 'NonBeatle' (ConcreteColleague) – người dùng không thuộc nhóm Beatle
/// </summary>
public class NonBeatle : Participant
{
    // Khởi tạo kèm tên
    public NonBeatle(string name) : base(name) { }

    // Ghi đè hiển thị khi nhận tin
    public override void Receive(string from, string message)
    {
        Console.Write("Gửi đến người ngoài nhóm Beatle: ");
        base.Receive(from, message);
    }
}
