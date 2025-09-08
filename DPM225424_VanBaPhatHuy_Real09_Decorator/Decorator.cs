// Lớp Decorator: kế thừa từ LibraryItem
// Dùng để "trang trí" (bổ sung chức năng) cho một LibraryItem đã có
public abstract class Decorator : LibraryItem
{
    // Đối tượng LibraryItem được gói (wrap) bên trong
    protected LibraryItem libraryItem;

    // Hàm khởi tạo: nhận vào một LibraryItem để lưu trữ
    public Decorator(LibraryItem libraryItem)
    {
        this.libraryItem = libraryItem;
    }

    // Gọi lại phương thức Display() của LibraryItem bên trong
    public override void Display()
    {
        libraryItem.Display();
    }
}
