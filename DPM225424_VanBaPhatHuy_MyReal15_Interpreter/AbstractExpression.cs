/// <summary>
/// Lớp trừu tượng AbstractExpression – định nghĩa giao diện chung cho tất cả biểu thức
/// </summary>
public abstract class AbstractExpression
{
    // Diễn giải biểu thức trên Context (kết quả được đẩy vào stack của Context)
    public abstract void Interpret(Context context);
}
