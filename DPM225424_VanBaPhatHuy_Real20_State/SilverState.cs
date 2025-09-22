
/// <summary>
/// Trạng thái 'Silver' – bình thường, KHÔNG tính lãi; 0 ≤ số dư < 1000
/// </summary>
public class SilverState : State
{
    // Khởi tạo từ trạng thái trước
    public SilverState(State state) : this(state.Balance, state.Account) { }

    // Khởi tạo với số dư & tài khoản
    public SilverState(double balance, Account account)
    {
        this.balance = balance;
        this.account = account;
        Initialize();
    }

    // Thiết lập thông số cho trạng thái Silver
    private void Initialize()
    {
        // Thực tế có thể lấy từ cấu hình/DB
        interest = 0.0;
        lowerLimit = 0.0;
        upperLimit = 1000.0;
    }

    public override void Deposit(double amount)
    {
        balance += amount;
        StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
        balance -= amount;
        StateChangeCheck();
    }

    public override void PayInterest()
    {
        balance += interest * balance; // interest = 0.0 → không đổi
        StateChangeCheck();
    }

    // Chuyển trạng thái theo số dư
    private void StateChangeCheck()
    {
        if (balance < lowerLimit)
        {
            account.State = new RedState(this);
        }
        else if (balance > upperLimit)
        {
            account.State = new GoldState(this);
        }
    }
}
