using System.Text;

/// <summary>
/// Mẫu thiết kế Flyweight (Chia sẻ đối tượng để tiết kiệm bộ nhớ)
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo tài liệu văn bản mẫu
        string document = "AAZZBBZB";

        // Chuyển chuỗi thành mảng ký tự để duyệt từng ký tự
        char[] chars = document.ToCharArray();

        // Tạo Factory để quản lý và cung cấp các đối tượng ký tự (Flyweight)
        CharacterFactory factory = new CharacterFactory();

        // Trạng thái ngoại sinh (ví dụ: cỡ chữ)
        int pointSize = 10;

        // Với mỗi ký tự trong tài liệu, dùng đối tượng Flyweight đã tạo/được chia sẻ
        foreach (char c in chars)
        {
            pointSize++; // tăng kích thước font mỗi lần lặp
            Character character = factory.GetCharacter(c); // lấy đối tượng ký tự từ Factory
            character.Display(pointSize); // hiển thị ký tự với cỡ chữ hiện tại
        }

        // Chờ người dùng nhấn phím trước khi thoát
        Console.ReadKey();
    }
}