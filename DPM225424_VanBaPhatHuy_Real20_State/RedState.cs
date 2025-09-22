
/// <summary>
/// Trạng thái 'Red' – tài khoản bị âm (quá hạn), không thể rút, không tính lãi
/// </summary>
public class RedState : State
{
    private double serviceFee; // Phí dịch vụ khi cố gắng rút trong trạng thái âm

    // Khởi tạo từ trạng thái trước đó
    public RedState(State state)
    {
        this.balance = state.Balance;
        this.account = state.Account;
        Initialize();
    }

    // Thiết lập thông số cho trạng thái Red
    private void Initialize()
    {
        // Thực tế có thể lấy từ cấu hình/DB
        interest = 0.0;
        lowerLimit = -100.0;
        upperLimit = 0.0;
        serviceFee = 15.00;
    }

    public override void Deposit(double amount)
    {
        balance += amount;
        StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
        amount = amount - serviceFee; // minh họa phí giao dịch khi âm
        Console.WriteLine("Không thể rút tiền do tài khoản đang âm!");
    }

    public override void PayInterest()
    {
        // Không trả lãi trong trạng thái âm
    }

    // Kiểm tra để chuyển trạng thái
    private void StateChangeCheck()
    {
        if (balance > upperLimit)
        {
            account.State = new SilverState(this);
        }
    }
}
