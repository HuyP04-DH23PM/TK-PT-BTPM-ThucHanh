using System;
using System.Collections.Generic;

// 'Composite' là lớp đại diện cho các node "tổ hợp" (có thể chứa con)
// Nó kế thừa từ Component và cài đặt các thao tác quản lý con
public class Composite : Component
{
    // Danh sách các Component con (có thể là Leaf hoặc Composite khác)
    List<Component> children = new List<Component>();

    // Hàm khởi tạo: truyền tên cho Composite, gọi constructor của Component
    public Composite(string name)
        : base(name)
    {
    }

    // Thêm một component con
    public override void Add(Component component)
    {
        children.Add(component);
    }

    // Xóa một component con
    public override void Remove(Component component)
    {
        children.Remove(component);
    }

    // Hiển thị Composite và các con của nó theo cấu trúc cây
    public override void Display(int depth)
    {
        // In ra tên của Composite, có thụt dòng để biểu diễn cấp độ
        Console.WriteLine(new String('-', depth) + name);

        // Đệ quy hiển thị các component con (tăng độ thụt dòng)
        foreach (Component component in children)
        {
            component.Display(depth + 2);
        }
    }
}
