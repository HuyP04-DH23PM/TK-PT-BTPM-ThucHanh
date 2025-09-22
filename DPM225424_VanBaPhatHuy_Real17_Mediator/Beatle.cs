
/// <summary>
/// Lớp 'Beatle' (ConcreteColleague) – người dùng thuộc nhóm Beatle
/// </summary>
public class Beatle : Participant
{
    // Khởi tạo kèm tên
    public Beatle(string name) : base(name) { }

    // Ghi đè hiển thị khi nhận tin
    public override void Receive(string from, string message)
    {
        Console.Write("Gửi đến một Beatle: ");
        base.Receive(from, message);
    }
}
