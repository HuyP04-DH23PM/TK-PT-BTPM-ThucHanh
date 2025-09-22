
using System.Text;

/// <summary>
/// Lớp Receiver – thực hiện thực sự các phép tính
/// </summary>
public class Calculator
{
    int curr = 0; // Giá trị hiện tại của máy tính

    public void Operation(char @operator, int operand)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Thực hiện phép tính dựa vào toán tử
        switch (@operator)
        {
            case '+': curr += operand; break;
            case '-': curr -= operand; break;
            case '*': curr *= operand; break;
            case '/': curr /= operand; break;
        }
        Console.WriteLine(
            "Giá trị hiện tại = {0,3} (sau khi {1} {2})",
            curr, @operator, operand);
    }
}
