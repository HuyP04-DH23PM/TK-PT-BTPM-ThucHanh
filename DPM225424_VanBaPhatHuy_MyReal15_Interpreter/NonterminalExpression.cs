using System;

/// <summary>
/// Biểu thức không kết thúc: kết hợp 2 biểu thức bằng AND/OR
/// </summary>
public class NonterminalExpression : AbstractExpression
{
    private readonly AbstractExpression _left;
    private readonly AbstractExpression _right;
    private readonly string _op; // "AND" hoặc "OR"

    public NonterminalExpression(AbstractExpression left, string op, AbstractExpression right)
    {
        _left = left;
        _right = right;
        _op = op?.Trim().ToUpperInvariant() ?? "AND";
    }

    public override void Interpret(Context context)
    {
        _left.Interpret(context);
        bool l = context.Pop();

        _right.Interpret(context);
        bool r = context.Pop();

        bool result = _op == "AND" ? (l && r) : (l || r);
        Console.WriteLine($"⇒ ({_op}) kết quả: {(result ? "Đúng" : "Sai")}");
        context.Push(result);
    }
}
