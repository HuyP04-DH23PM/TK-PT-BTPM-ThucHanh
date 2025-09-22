
/// <summary>
/// Lớp 'Memento' – gói trạng thái chụp lại của SalesProspect
/// (Ví dụ này cho phép get/set công khai để minh họa, thực tế có thể giới hạn để đảm bảo bao đóng)
/// </summary>
public class Memento
{
    string name;
    string phone;
    double budget;

    // Hàm khởi tạo – nhận trạng thái để lưu
    public Memento(string name, string phone, double budget)
    {
        this.name = name;
        this.phone = phone;
        this.budget = budget;
    }

    // Thuộc tính: Tên đã lưu
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Thuộc tính: Điện thoại đã lưu
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    // Thuộc tính: Ngân sách đã lưu
    public double Budget
    {
        get { return budget; }
        set { budget = value; }
    }
}
