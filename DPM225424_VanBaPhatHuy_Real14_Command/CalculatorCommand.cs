
/// <summary>
/// Lớp ConcreteCommand – gói một yêu cầu cụ thể tới đối tượng Calculator
/// </summary>
public class CalculatorCommand : Command
{
    char @operator;           // Toán tử (cộng, trừ, nhân, chia)
    int operand;              // Toán hạng
    Calculator calculator;    // Đối tượng thực hiện (Receiver)

    // Hàm khởi tạo
    public CalculatorCommand(Calculator calculator, char @operator, int operand)
    {
        this.calculator = calculator;
        this.@operator = @operator;
        this.operand = operand;
    }

    // Gán toán tử mới (nếu cần)
    public char Operator
    {
        set { @operator = value; }
    }

    // Gán toán hạng mới (nếu cần)
    public int Operand
    {
        set { operand = value; }
    }

    // Thực thi lệnh mới
    public override void Execute()
    {
        calculator.Operation(@operator, operand);
    }

    // Hoàn tác lệnh cuối cùng (dùng toán tử ngược lại)
    public override void UnExecute()
    {
        calculator.Operation(Undo(@operator), operand);
    }

    // Xác định toán tử ngược lại (ví dụ + → -, * → /)
    private char Undo(char @operator)
    {
        switch (@operator)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default:
                throw new ArgumentException("@operator");
        }
    }
}
