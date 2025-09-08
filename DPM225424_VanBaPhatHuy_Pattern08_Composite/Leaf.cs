using System;

// 'Leaf' là lớp đại diện cho "lá" trong cấu trúc cây (node cuối, không có con)
// Nó kế thừa từ Component nhưng không thể chứa thêm Component con
public class Leaf : Component
{
    // Hàm khởi tạo: truyền tên cho Leaf, gọi constructor của Component
    public Leaf(string name)
        : base(name)
    {
    }

    // Lá không thể thêm con → in thông báo
    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }

    // Lá không thể xóa con → in thông báo
    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }

    // Hiển thị tên lá với mức thụt dòng tương ứng độ sâu trong cây
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}
