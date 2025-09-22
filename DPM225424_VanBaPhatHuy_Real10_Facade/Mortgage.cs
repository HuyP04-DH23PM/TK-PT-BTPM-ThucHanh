using System.Text;

public class Mortgage
{
    // Các subsystem: ngân hàng, khoản vay, tín dụng
    Bank bank = new Bank();
    Loan loan = new Loan();
    Credit credit = new Credit();

    // Kiểm tra xem khách hàng có đủ điều kiện vay không
    public bool IsEligible(Customer cust, int amount)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("{0} xin vay số tiền {1:C}\n",
            cust.Name, amount);

        bool eligible = true;

        // Kiểm tra lần lượt 3 điều kiện:
        // 1. Có đủ tiền tiết kiệm
        if (!bank.HasSufficientSavings(cust, amount))
        {
            eligible = false;
        }
        // 2. Không có nợ xấu
        else if (!loan.HasNoBadLoans(cust))
        {
            eligible = false;
        }
        // 3. Điểm tín dụng tốt
        else if (!credit.HasGoodCredit(cust))
        {
            eligible = false;
        }

        // Trả về kết quả cuối cùng
        return eligible;
    }
}
