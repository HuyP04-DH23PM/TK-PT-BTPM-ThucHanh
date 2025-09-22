using System.Text;

public class Bank
{
    // Kiểm tra xem khách hàng có đủ tiền tiết kiệm để vay không
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Ngân hàng kiểm tra tài khoản của " + c.Name);
        // Ở đây ví dụ đơn giản luôn trả về true (đủ điều kiện)
        return true;
    }
}
