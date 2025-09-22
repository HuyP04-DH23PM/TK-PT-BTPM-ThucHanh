/// <summary>
/// Lớp trừu tượng 'Flyweight' (Định nghĩa chung cho các ký tự)
/// </summary>
public abstract class Character
{
    // Các thuộc tính nội sinh (dùng chung giữa các đối tượng)
    protected char symbol;    // ký hiệu
    protected int width;      // độ rộng
    protected int height;     // chiều cao
    protected int ascent;     // khoảng cách từ đường cơ sở đến đỉnh ký tự
    protected int descent;    // khoảng cách từ đường cơ sở xuống đáy ký tự

    // Thuộc tính ngoại sinh: kích thước hiển thị (point size)
    protected int pointSize;

    // Phương thức hiển thị ký tự với kích thước cụ thể
    public abstract void Display(int pointSize);
}