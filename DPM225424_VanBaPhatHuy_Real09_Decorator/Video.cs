public class Video : LibraryItem
{
    private string director; // Đạo diễn
    private string title;    // Tựa video
    private int playTime;    // Thời lượng (phút)

    // Hàm khởi tạo: truyền vào đạo diễn, tựa, số bản sao và thời lượng
    public Video(string director, string title, int numCopies, int playTime)
    {
        this.director = director;
        this.title = title;
        this.NumCopies = numCopies;
        this.playTime = playTime;
    }

    // Hiển thị thông tin video
    public override void Display()
    {
        Console.WriteLine("\nVideo ----- ");
        Console.WriteLine(" Đạo diễn  : {0}", director);
        Console.WriteLine(" Tựa phim  : {0}", title);
        Console.WriteLine(" Số bản sao: {0}", NumCopies);
        Console.WriteLine(" Thời lượng: {0} phút\n", playTime);
    }
}
