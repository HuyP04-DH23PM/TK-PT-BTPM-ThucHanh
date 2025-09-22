
/// <summary>
/// Lớp Context – giữ dữ liệu vào/ra trong quá trình diễn giải
/// </summary>
public class Context
{
    // Chuỗi số La Mã đầu vào (sẽ bị cắt dần khi đã diễn giải)
    string input;

    // Kết quả số thập phân đầu ra
    int output;

    // Hàm khởi tạo
    public Context(string input)
    {
        this.input = input;
    }

    // Thuộc tính: Input (chuỗi La Mã còn lại)
    public string Input
    {
        get { return input; }
        set { input = value; }
    }

    // Thuộc tính: Output (giá trị thập phân đã tính)
    public int Output
    {
        get { return output; }
        set { output = value; }
    }
}
