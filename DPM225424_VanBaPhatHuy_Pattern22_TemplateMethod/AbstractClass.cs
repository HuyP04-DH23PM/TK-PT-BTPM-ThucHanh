
/// <summary>
/// Lớp trừu tượng 'AbstractClass' – định nghĩa khung thuật toán qua TemplateMethod
/// </summary>
public abstract class AbstractClass
{
    // Các “phép nguyên thủy” mà lớp con phải hiện thực
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();

    // Phương thức Khuôn mẫu (Template Method):
    // Ấn định thứ tự các bước của thuật toán và gọi các phép nguyên thủy
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine("");
    }
}
