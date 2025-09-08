public abstract class DrawingElement
{
    // Tên của phần tử (ví dụ: "Hình tròn", "Đường thẳng", "Nhóm hình")
    protected string name;

    // Hàm khởi tạo, gán tên cho phần tử
    public DrawingElement(string name)
    {
        this.name = name;
    }

    // Phương thức trừu tượng: thêm một phần tử con
    public abstract void Add(DrawingElement d);

    // Phương thức trừu tượng: xóa một phần tử con
    public abstract void Remove(DrawingElement d);

    // Phương thức trừu tượng: hiển thị phần tử với mức thụt lề
    public abstract void Display(int indent);
}
