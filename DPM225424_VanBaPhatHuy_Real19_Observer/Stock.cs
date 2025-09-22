
/// <summary>
/// Lớp trừu tượng 'Stock' (Subject) – quản lý danh sách Observer và phát thông báo khi giá thay đổi
/// </summary>
public abstract class Stock
{
    // Mã cổ phiếu (ví dụ: "IBM")
    private string symbol;

    // Giá hiện tại
    private double price;

    // Danh sách nhà đầu tư đăng ký theo dõi
    private List<IInvestor> investors = new List<IInvestor>();

    // Hàm khởi tạo
    public Stock(string symbol, double price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    // Đăng ký nhà đầu tư (Observer)
    public void Attach(IInvestor investor)
    {
        investors.Add(investor);
    }

    // Hủy đăng ký nhà đầu tư
    public void Detach(IInvestor investor)
    {
        investors.Remove(investor);
    }

    // Thông báo cho tất cả nhà đầu tư về thay đổi (gọi Update)
    public void Notify()
    {
        foreach (IInvestor investor in investors)
        {
            investor.Update(this);
        }
        Console.WriteLine("");
    }

    // Thuộc tính: Giá cổ phiếu (đổi giá sẽ Notify)
    public double Price
    {
        get { return price; }
        set
        {
            if (price != value)
            {
                price = value;
                Notify();
            }
        }
    }

    // Thuộc tính: Mã cổ phiếu
    public string Symbol
    {
        get { return symbol; }
    }
}
