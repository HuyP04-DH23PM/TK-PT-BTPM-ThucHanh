
/// <summary>
/// Lớp TerminalExpression – bậc hàng đơn vị
/// Ghi chú: kiểm tra I, IV, V, IX (và nhiều I liên tiếp như II, III)
/// </summary>
public class OneExpression : Expression
{
    public override string One() { return "I"; }
    public override string Four() { return "IV"; }
    public override string Five() { return "V"; }
    public override string Nine() { return "IX"; }
    public override int Multiplier() { return 1; }
}
