
/// <summary>
/// Lớp 'ProspectMemory' (Caretaker) – nơi cất giữ Memento, không can thiệp nội dung
/// </summary>
public class ProspectMemory
{
    // Lưu một Memento (có thể mở rộng thành ngăn xếp để hỗ trợ nhiều lần Undo/Redo)
    Memento memento;

    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}
