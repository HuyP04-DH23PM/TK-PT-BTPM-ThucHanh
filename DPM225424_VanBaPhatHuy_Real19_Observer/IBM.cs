
/// <summary>
/// Lớp 'IBM' (ConcreteSubject) – kế thừa Stock, không thêm hành vi ngoài việc đặt tên/giá ban đầu
/// </summary>
public class IBM : Stock
{
    // Hàm khởi tạo
    public IBM(string symbol, double price) : base(symbol, price) { }
}
