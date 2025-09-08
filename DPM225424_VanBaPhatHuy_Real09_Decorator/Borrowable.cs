public class Borrowable : Decorator
{
    // Danh sách người đang mượn item này
    protected readonly List<string> borrowers = new List<string>();

    // Hàm khởi tạo: nhận vào một LibraryItem (ví dụ: Book, Video) để "trang trí"
    public Borrowable(LibraryItem libraryItem)
        : base(libraryItem)
    {
    }

    // Mượn item → thêm người mượn vào danh sách, giảm số bản sao
    public void BorrowItem(string name)
    {
        borrowers.Add(name);
        libraryItem.NumCopies--;
    }

    // Trả item → xóa người mượn khỏi danh sách, tăng số bản sao
    public void ReturnItem(string name)
    {
        borrowers.Remove(name);
        libraryItem.NumCopies++;
    }

    // Hiển thị thông tin item + danh sách người đang mượn
    public override void Display()
    {
        base.Display();
        foreach (string borrower in borrowers)
        {
            Console.WriteLine(" Người mượn: " + borrower);
        }
    }
}
