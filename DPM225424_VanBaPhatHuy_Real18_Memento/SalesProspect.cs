
/// <summary>
/// Lớp 'SalesProspect' (Originator) – đối tượng có trạng thái cần lưu/khôi phục
/// </summary>
public class SalesProspect
{
    string name;
    string phone;
    double budget;

    // Thuộc tính: Tên (đặt giá trị sẽ in ra để theo dõi)
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
            Console.WriteLine("Tên:     " + name);
        }
    }

    // Thuộc tính: Số điện thoại (đặt giá trị sẽ in ra để theo dõi)
    public string Phone
    {
        get { return phone; }
        set
        {
            phone = value;
            Console.WriteLine("Điện thoại: " + phone);
        }
    }

    // Thuộc tính: Ngân sách (đặt giá trị sẽ in ra để theo dõi)
    public double Budget
    {
        get { return budget; }
        set
        {
            budget = value;
            Console.WriteLine("Ngân sách:  " + budget);
        }
    }

    // Lưu trạng thái hiện tại vào Memento
    public Memento SaveMemento()
    {
        Console.WriteLine("\n— Đang lưu trạng thái —\n");
        return new Memento(name, phone, budget);
    }

    // Khôi phục trạng thái từ Memento
    public void RestoreMemento(Memento memento)
    {
        Console.WriteLine("\n— Đang khôi phục trạng thái —\n");
        Name = memento.Name;
        Phone = memento.Phone;
        Budget = memento.Budget;
    }
}
