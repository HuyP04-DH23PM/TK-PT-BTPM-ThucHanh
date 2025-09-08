using System;

// 'Compound' là lớp Target – giao diện mà client mong muốn làm việc cùng
public class Compound
{
    // Các thuộc tính cơ bản của một hợp chất
    protected float boilingPoint;       // Nhiệt độ sôi
    protected float meltingPoint;       // Nhiệt độ nóng chảy
    protected double molecularWeight;   // Khối lượng phân tử
    protected string molecularFormula;  // Công thức phân tử

    // Phương thức hiển thị thông tin hợp chất
    // Lớp cơ sở chỉ hiển thị mặc định là "Unknown"
    public virtual void Display()
    {
        Console.WriteLine("\nCompound: Unknown ------ ");
    }
}
