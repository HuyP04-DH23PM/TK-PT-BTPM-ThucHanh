using System;
using System.Text;

/// <summary>
/// Biểu thức kết thúc: kiểm tra 1 điều kiện đơn (token DSL)
/// </summary>
public class TerminalExpression : AbstractExpression
{
    private readonly string _token;

    public TerminalExpression(string token)
    {
        _token = token;
    }

    public override void Interpret(Context context)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool ok = context.EvaluateToken(_token);
        Console.WriteLine($"• Kiểm tra '{_token}' → {(ok ? "Đúng" : "Sai")}");
        context.Push(ok);
    }
}
