
/// <summary>
/// Lớp 'Investor' (ConcreteObserver) – nhận thông báo khi Stock thay đổi
/// </summary>
public class Investor : IInvestor
{
    private string name;
    private Stock stock; // Thuộc tính minh họa (không bắt buộc dùng trong ví dụ)

    // Hàm khởi tạo
    public Investor(string name)
    {
        this.name = name;
    }

    // Khi được Subject thông báo, in ra thông tin thay đổi giá
    public void Update(Stock stock)
    {
        Console.WriteLine("Đã thông báo {0}: giá của {1} thay đổi thành {2:C}",
            name, stock.Symbol, stock.Price);
    }

    // Thuộc tính: Stock đang quan tâm (tùy chọn)
    public Stock Stock
    {
        get { return stock; }
        set { stock = value; }
    }
}
