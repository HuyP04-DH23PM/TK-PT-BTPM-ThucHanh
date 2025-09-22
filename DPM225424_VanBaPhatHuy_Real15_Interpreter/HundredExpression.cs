
/// <summary>
/// Lớp TerminalExpression – bậc hàng trăm
/// Ghi chú: kiểm tra C, CD, D, hoặc CM
/// </summary>
public class HundredExpression : Expression
{
    public override string One() { return "C"; }
    public override string Four() { return "CD"; }
    public override string Five() { return "D"; }
    public override string Nine() { return "CM"; }
    public override int Multiplier() { return 100; }
}
