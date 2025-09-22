/// <summary>
/// Lớp 'ConcreteFlyweight' cho ký tự A
/// </summary>
public class CharacterA : Character
{
    // Hàm khởi tạo: gán các giá trị nội sinh của ký tự A
    public CharacterA()
    {
        symbol = 'A';
        height = 100;
        width = 120;
        ascent = 70;
        descent = 0;
    }

    public override void Display(int pointSize)
    {
        // Lưu kích thước ngoại sinh và hiển thị thông tin
        this.pointSize = pointSize;
        Console.WriteLine(symbol + " (kích thước " + this.pointSize + ")");
    }
}