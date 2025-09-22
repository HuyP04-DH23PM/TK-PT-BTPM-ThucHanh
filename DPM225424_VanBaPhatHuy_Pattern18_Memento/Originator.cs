
/// <summary>
/// Lớp 'Originator' – đối tượng có trạng thái cần lưu/khôi phục
/// </summary>
public class Originator
{
    // Trạng thái bên trong cần được chụp (snapshot)
    string state;

    // Thuộc tính trạng thái; khi set sẽ in ra trạng thái hiện tại
    public string State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("Trạng thái = " + state);
        }
    }

    // Tạo Memento (ảnh chụp trạng thái hiện tại)
    public Memento CreateMemento()
    {
        return new Memento(state);
    }

    // Khôi phục trạng thái từ Memento
    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Đang khôi phục trạng thái...");
        State = memento.State;
    }
}
