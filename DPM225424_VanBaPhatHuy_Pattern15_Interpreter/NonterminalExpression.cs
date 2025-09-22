
/// <summary>
/// Lớp NonterminalExpression – biểu thức không kết thúc (nút cha) trong cây cú pháp
/// </summary>
public class NonterminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Console.WriteLine("Đã gọi Nonterminal.Interpret()");
    }
}
