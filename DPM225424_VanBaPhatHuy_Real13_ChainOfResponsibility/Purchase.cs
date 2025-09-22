
/// <summary>
/// Lớp chứa thông tin yêu cầu mua hàng (Purchase)
/// </summary>
public class Purchase
{
    // Mã yêu cầu
    int number;

    // Số tiền yêu cầu
    double amount;

    // Mục đích/diễn giải nhu cầu mua
    string purpose;

    // Hàm khởi tạo
    public Purchase(int number, double amount, string purpose)
    {
        this.number = number;
        this.amount = amount;
        this.purpose = purpose;
    }

    // Thuộc tính: mã yêu cầu
    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    // Thuộc tính: số tiền
    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    // Thuộc tính: mục đích mua
    public string Purpose
    {
        get { return purpose; }
        set { purpose = value; }
    }
}
