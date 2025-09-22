using System.Text;

/// <summary>
/// Lớp 'ConcreteFlyweight' cho ký tự Z
/// </summary>
public class CharacterZ : Character
{
    // Hàm khởi tạo: gán các giá trị nội sinh của ký tự Z
    public CharacterZ()
    {
        symbol = 'Z';
        height = 100;
        width = 100;
        ascent = 68;
        descent = 0;
    }

    public override void Display(int pointSize)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Lưu kích thước ngoại sinh và hiển thị thông tin
        this.pointSize = pointSize;
        Console.WriteLine(this.symbol + " (kích thước " + this.pointSize + ")");
    }
}