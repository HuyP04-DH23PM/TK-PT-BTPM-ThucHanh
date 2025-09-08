public class Credit
{
    // Kiểm tra lịch sử tín dụng của khách hàng
    public bool HasGoodCredit(Customer c)
    {
        Console.WriteLine("Kiểm tra điểm tín dụng của " + c.Name);
        // Ở ví dụ đơn giản này, luôn cho kết quả tốt (true)
        return true;
    }
}
