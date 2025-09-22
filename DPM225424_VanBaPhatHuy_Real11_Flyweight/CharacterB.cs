using System.Text;

/// <summary>
/// Lớp 'ConcreteFlyweight' cho ký tự B
/// </summary>
public class CharacterB : Character
{

    // Hàm khởi tạo: gán các giá trị nội sinh của ký tự B
    public CharacterB()
    {
        symbol = 'B';
        height = 100;
        width = 140;
        ascent = 72;
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