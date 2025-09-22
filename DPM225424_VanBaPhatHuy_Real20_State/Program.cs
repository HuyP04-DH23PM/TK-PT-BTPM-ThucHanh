using System;

/// <summary>
/// Mẫu thiết kế State (Trạng thái) – ví dụ thực tế: tài khoản ngân hàng đổi trạng thái theo số dư
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Mở tài khoản mới
        Account account = new Account("Jim Johnson");

        // Thực hiện các giao dịch tài chính
        account.Deposit(500.0);
        account.Deposit(300.0);
        account.Deposit(550.0);
        account.PayInterest();
        account.Withdraw(2000.00);
        account.Withdraw(1100.00);

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}
