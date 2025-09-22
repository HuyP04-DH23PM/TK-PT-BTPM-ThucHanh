
/// <summary>
/// Lớp trừu tượng 'State' – định nghĩa hành vi ở từng trạng thái
/// </summary>
public abstract class State
{
    // Ngữ cảnh (tài khoản) mà trạng thái đang áp dụng
    protected Account account;

    // Số dư hiện tại
    protected double balance;

    // Lãi suất áp dụng cho trạng thái
    protected double interest;

    // Giới hạn dưới & trên để chuyển trạng thái
    protected double lowerLimit;
    protected double upperLimit;

    // Thuộc tính truy cập ngữ cảnh
    public Account Account
    {
        get { return account; }
        set { account = value; }
    }

    // Thuộc tính số dư (được các trạng thái cập nhật)
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Hành vi chính mà mỗi trạng thái phải hiện thực
    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void PayInterest();
}
