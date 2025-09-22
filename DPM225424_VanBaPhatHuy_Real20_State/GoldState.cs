
/// <summary>
/// Trạng thái 'Gold' – có tính lãi; số dư ≥ 1000
/// </summary>
public class GoldState : State
{
    // Khởi tạo từ trạng thái trước
    public GoldState(State state) : this(state.Balance, state.Account) { }

    // Khởi tạo với số dư & tài khoản
    public GoldState(double balance, Account account)
    {
        this.balance = balance;
        this.account = account;
        Initialize();
    }

    // Thiết lập thông số cho trạng thái Gold
    private void Initialize()
    {
        // Thực tế có thể lấy từ DB
        interest = 0.05;       // 5%/kỳ minh họa
        lowerLimit = 1000.0;
        upperLimit = 10000000.0; // trần minh họa
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
        balance += interest * balance;
        StateChangeCheck();
    }

    // Chuyển trạng thái khi tụt dưới ngưỡng
    private void StateChangeCheck()
    {
        if (balance < 0.0)
        {
            account.State = new RedState(this);
        }
        else if (balance < lowerLimit)
        {
            account.State = new SilverState(this);
        }
    }
}
