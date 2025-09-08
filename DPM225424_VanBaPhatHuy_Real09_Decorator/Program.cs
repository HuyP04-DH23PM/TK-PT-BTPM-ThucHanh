public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một quyển sách và hiển thị thông tin
        Book book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();

        // Tạo một video và hiển thị thông tin
        Video video = new Video("Spielberg", "Jaws", 23, 92);
        video.Display();

        // Biến video thành dạng có thể mượn (Borrowable)
        // Sau đó cho 2 khách hàng mượn
        Console.WriteLine("\nBiến video thành dạng có thể mượn:");

        Borrowable borrowvideo = new Borrowable(video);
        borrowvideo.BorrowItem("Khách hàng #1");
        borrowvideo.BorrowItem("Khách hàng #2");

        // Hiển thị thông tin video + danh sách người mượn
        borrowvideo.Display();

        // Dừng màn hình, chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
