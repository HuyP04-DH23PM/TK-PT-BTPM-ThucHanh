// 'Component' là lớp trừu tượng (abstract class) trong Composite Pattern
// Nó định nghĩa giao diện chung cho cả "Leaf" (lá) và "Composite" (nhánh)
public abstract class Component
{
    // Tên của component (ví dụ: tên file, thư mục, node…)
    protected string name;

    // Hàm khởi tạo: nhận vào tên của component
    public Component(string name)
    {
        this.name = name;
    }

    // Thêm một component con (đối với Leaf có thể không làm gì)
    public abstract void Add(Component c);

    // Xóa một component con
    public abstract void Remove(Component c);

    // Hiển thị component (với mức độ thụt dòng depth để minh họa cấu trúc cây)
    public abstract void Display(int depth);
}
