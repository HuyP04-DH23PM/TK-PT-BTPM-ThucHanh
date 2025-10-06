/// <summary>
/// Lớp 'Memento' – gói trạng thái đã chụp của Originator (bất biến với bên ngoài)
/// MyReal: lưu snapshot mô tả trạng thái đơn hàng (ví dụ: "AGU-ORDER-001 | Soạn hàng")
/// </summary>
public class Memento
{
    // Trạng thái được lưu trữ
    string state;

    // Hàm khởi tạo – nhận trạng thái để lưu
    public Memento(string state)
    {
        this.state = state;
    }

    // Chỉ đọc: trả về trạng thái đã lưu
    public string State
    {
        get { return state; }
    }
}
