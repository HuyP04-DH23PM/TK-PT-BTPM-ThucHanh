// 'Decorator' (MyReal): lớp bọc dịch vụ gia tăng quanh đơn hàng
// Ví dụ cụ thể: ConcreteDecoratorA = Đóng gói chống ẩm, ConcreteDecoratorB = Giao nhanh
public abstract class Decorator : Component
{
    protected Component component;

    public void SetComponent(Component component)
    {
        this.component = component;
    }

    public override void Operation()
    {
        if (component != null)
        {
            component.Operation(); // Ủy quyền cho bước/bọc trước đó
        }
    }
}
