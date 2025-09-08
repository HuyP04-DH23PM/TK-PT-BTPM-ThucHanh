public class Loan
{
    // Kiểm tra xem khách hàng có các khoản vay xấu (nợ xấu) hay không
    public bool HasNoBadLoans(Customer c)
    {
        Console.WriteLine("Kiểm tra lịch sử vay vốn của " + c.Name);
        // Ở ví dụ này, luôn cho rằng khách hàng không có nợ xấu
        return true;
    }
}
