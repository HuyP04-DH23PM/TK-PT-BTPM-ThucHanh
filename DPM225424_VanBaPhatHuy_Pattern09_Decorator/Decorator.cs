// 'Decorator' là lớp trừu tượng (abstract class) kế thừa từ Component
// Nó giữ một tham chiếu đến một Component khác và ủy quyền cho Component đó
public abstract class Decorator : Component
{
    // Component mà decorator sẽ "bọc" quanh
    protected Component component;

    // Gán component cụ thể để decorator bọc
    public void SetComponent(Component component)
    {
        this.component = component;
    }

    // Ghi đè phương thức Operation
    // Nếu có component bên trong thì gọi Operation() của nó
    public override void Operation()
    {
        if (component != null)
        {
            component.Operation();
        }
    }
}
