public class CompositeElement : DrawingElement
{
    // Danh sách các phần tử con (có thể là hình cơ bản hoặc nhóm khác)
    List<DrawingElement> elements = new List<DrawingElement>();

    // Hàm khởi tạo với tên phần tử
    public CompositeElement(string name)
        : base(name)
    {
    }

    // Thêm phần tử con vào danh sách
    public override void Add(DrawingElement d)
    {
        elements.Add(d);
    }

    // Xóa phần tử con ra khỏi danh sách
    public override void Remove(DrawingElement d)
    {
        elements.Remove(d);
    }

    // Hiển thị tên phần tử và các phần tử con kèm theo mức thụt
    public override void Display(int indent)
    {
        Console.WriteLine(new String('-', indent) + "+ " + name);

        // Duyệt và hiển thị từng phần tử con
        foreach (DrawingElement d in elements)
        {
            d.Display(indent + 2);
        }
    }
}
