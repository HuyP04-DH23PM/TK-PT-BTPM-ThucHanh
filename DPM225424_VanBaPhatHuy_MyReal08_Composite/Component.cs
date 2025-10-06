// 'Component' là lớp trừu tượng (abstract class) trong Composite Pattern
// MyReal: đại diện một "mục danh mục" (có thể là Nhóm hoặc Sản phẩm)
public abstract class Component
{
    protected string name;

    protected Component(string name)
    {
        this.name = name;
    }

    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth); // depth dùng để thụt dòng khi in cây
}
