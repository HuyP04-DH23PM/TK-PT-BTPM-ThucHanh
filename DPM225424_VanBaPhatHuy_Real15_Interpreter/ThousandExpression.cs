
/// <summary>
/// Lớp TerminalExpression – bậc hàng nghìn
/// Ghi chú: kiểm tra ký hiệu 'M'
/// </summary>
public class ThousandExpression : Expression
{
    public override string One() { return "M"; }
    public override string Four() { return " "; }  // Không dùng ở bậc này
    public override string Five() { return " "; }  // Không dùng ở bậc này
    public override string Nine() { return " "; }  // Không dùng ở bậc này
    public override int Multiplier() { return 1000; }
}
