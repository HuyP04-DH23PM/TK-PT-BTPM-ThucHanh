// Lớp trừu tượng LibraryItem: đại diện cho một tài liệu trong thư viện
// Có thể là sách, video, hoặc bất kỳ loại tài liệu nào khác
public abstract class LibraryItem
{
    // Thuộc tính: số lượng bản sao hiện có trong thư viện
    private int numCopies;

    public int NumCopies
    {
        get { return numCopies; }
        set { numCopies = value; }
    }

    // Phương thức trừu tượng: hiển thị thông tin của item
    public abstract void Display();
}
