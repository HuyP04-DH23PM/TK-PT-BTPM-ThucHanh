using System.Text;

public class Book : LibraryItem
{
    private string author; // Tác giả
    private string title;  // Tựa sách

    // Hàm khởi tạo: nhận vào tác giả, tựa sách và số lượng bản sao
    public Book(string author, string title, int numCopies)
    {
        this.author = author;
        this.title = title;
        this.NumCopies = numCopies;
    }

    // Hiển thị thông tin sách
    public override void Display()
    {
        Console.OutputEncoding = Encoding.UTF8; // Quan trọng
        Console.WriteLine("\nBook ------ ");
        Console.WriteLine(" Tác giả   : {0}", author);
        Console.WriteLine(" Tựa sách  : {0}", title);
        Console.WriteLine(" Số bản sao: {0}", NumCopies);
    }
}
