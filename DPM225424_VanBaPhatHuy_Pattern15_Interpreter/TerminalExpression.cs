
using System.Text;

/// <summary>
/// Lớp TerminalExpression – biểu thức kết thúc (lá) trong cây cú pháp
/// </summary>
public class TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Đã gọi Terminal.Interpret()");
    }
}
