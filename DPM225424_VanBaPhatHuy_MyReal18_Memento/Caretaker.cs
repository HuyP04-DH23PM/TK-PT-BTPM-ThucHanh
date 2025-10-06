/// <summary>
/// Lớp 'Caretaker' (Người bảo quản) – giữ Memento nhưng không can thiệp nội dung
/// MyReal: tạm cất snapshot để có thể khôi phục trạng thái đơn hàng
/// </summary>
public class Caretaker
{
    // Lưu một Memento (có thể mở rộng thành stack cho Undo/Redo)
    Memento memento;

    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}
