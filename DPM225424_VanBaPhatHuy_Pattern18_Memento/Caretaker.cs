
/// <summary>
/// Lớp 'Caretaker' (Người bảo quản) – giữ Memento nhưng không can thiệp nội dung
/// </summary>
public class Caretaker
{
    // Lưu một Memento (có thể mở rộng thành stack/queue để hỗ trợ nhiều mức Undo/Redo)
    Memento memento;

    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}
