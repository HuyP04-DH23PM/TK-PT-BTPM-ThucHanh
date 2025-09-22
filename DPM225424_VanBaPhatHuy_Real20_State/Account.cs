
using System.Text;

/// <summary>
/// Lớp 'Account' (Context) – ủy quyền hành vi cho trạng thái hiện tại
/// </summary>
public class Account
{
    private State state;    // Trạng thái hiện tại
    private string owner;   // Chủ tài khoản (minh họa)

    // Khởi tạo: mặc định trạng thái Silver với số dư 0
    public Account(string owner)
    {
        this.owner = owner;
        this.state = new SilverState(0.0, this);
    }

    // Chỉ đọc: số dư hiện tại (lấy từ trạng thái)
    public double Balance
    {
        get { return state.Balance; }
    }

    // Thuộc tính trạng thái hiện tại
    public State State
    {
        get { return state; }
        set { state = value; }
    }

    // Gửi tiền
    public void Deposit(double amount)
    {
        Console.OutputEncoding = Encoding.UTF8;
        state.Deposit(amount);
        Console.WriteLine("Đã gửi:   {0:C} --- ", amount);
        Console.WriteLine("  Số dư  = {0:C}", this.Balance);
        Console.WriteLine("  Trạng thái = {0}", this.State.GetType().Name);
        Console.WriteLine("");
    }

    // Rút tiền
    public void Withdraw(double amount)
    {
        state.Withdraw(amount);
        Console.WriteLine("Đã rút:   {0:C} --- ", amount);
        Console.WriteLine("  Số dư  = {0:C}", this.Balance);
        Console.WriteLine("  Trạng thái = {0}\n", this.State.GetType().Name);
    }

    // Trả lãi (nếu trạng thái có lãi)
    public void PayInterest()
    {
        state.PayInterest();
        Console.WriteLine("Đã trả lãi --- ");
        Console.WriteLine("  Số dư  = {0:C}", this.Balance);
        Console.WriteLine("  Trạng thái = {0}\n", this.State.GetType().Name);
    }
}
