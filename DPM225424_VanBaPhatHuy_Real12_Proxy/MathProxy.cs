/// <summary>
/// Lớp 'MathProxy' (Proxy) – đại diện cho Math, kiểm soát truy cập
/// </summary>
public class MathProxy : IMath
{
    // Tham chiếu đến đối tượng Math thật
    private Math math = new Math();

    public double Add(double x, double y)
    {
        // Có thể thêm logic kiểm tra, log… trước khi gọi thực tế
        return math.Add(x, y);
    }

    public double Sub(double x, double y)
    {
        return math.Sub(x, y);
    }

    public double Mul(double x, double y)
    {
        return math.Mul(x, y);
    }

    public double Div(double x, double y)
    {
        return math.Div(x, y);
    }
}