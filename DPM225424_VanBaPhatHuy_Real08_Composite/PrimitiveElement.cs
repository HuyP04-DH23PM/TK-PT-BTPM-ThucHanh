public class PrimitiveElement : DrawingElement
{
    // Hàm khởi tạo: gán tên cho phần tử cơ bản (ví dụ: đường, hình tròn)
    public PrimitiveElement(string name)
        : base(name)
    {
    }

    // Phần tử cơ bản không thể thêm con → thông báo lỗi
    public override void Add(DrawingElement c)
    {
        Console.WriteLine("Không thể thêm vào phần tử cơ bản (PrimitiveElement)");
    }

    // Phần tử cơ bản không thể xóa con → thông báo lỗi
    public override void Remove(DrawingElement c)
    {
        Console.WriteLine("Không thể xóa từ phần tử cơ bản (PrimitiveElement)");
    }

    // Hiển thị tên phần tử với mức thụt lề
    public override void Display(int indent)
    {
        Console.WriteLine(new String('-', indent) + " " + name);
    }
}
