public class Program
{
    public static void Main(string[] args)
    {
        // Tạo nút gốc (root) cho cây cấu trúc hình vẽ
        CompositeElement root = new CompositeElement("Picture");

        // Thêm các phần tử cơ bản (Primitive) vào gốc
        root.Add(new PrimitiveElement("Red Line"));
        root.Add(new PrimitiveElement("Blue Circle"));
        root.Add(new PrimitiveElement("Green Box"));

        // Tạo một nhóm (Composite) gồm 2 hình tròn
        CompositeElement comp = new CompositeElement("Two Circles");
        comp.Add(new PrimitiveElement("Black Circle"));
        comp.Add(new PrimitiveElement("White Circle"));

        // Thêm nhóm này vào gốc
        root.Add(comp);

        // Tạo phần tử cơ bản mới rồi thử thêm và xóa
        PrimitiveElement pe = new PrimitiveElement("Yellow Line");
        root.Add(pe);
        root.Remove(pe); // sau khi thêm thì xóa ngay

        // Hiển thị toàn bộ cấu trúc (theo dạng cây, có thụt lề)
        root.Display(1);

        // Dừng màn hình để chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
