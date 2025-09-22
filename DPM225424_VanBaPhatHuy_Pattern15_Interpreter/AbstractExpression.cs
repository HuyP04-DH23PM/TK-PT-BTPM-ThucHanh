
/// <summary>
/// Lớp trừu tượng AbstractExpression – định nghĩa giao diện chung cho tất cả biểu thức
/// </summary>
public abstract class AbstractExpression
{
    // Phương thức trừu tượng để diễn giải biểu thức
    public abstract void Interpret(Context context);
}
