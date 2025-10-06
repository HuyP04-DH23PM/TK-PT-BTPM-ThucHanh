// Abstraction: Bộ điều khiển tưới tiêu (tầng giao diện quản lý)
public class Abstraction
{
    protected Implementor implementor;

    public Implementor Implementor
    {
        set { implementor = value; }
    }

    // Giao diện điều khiển tưới tiêu cấp cao
    public virtual void Operation()
    {
        implementor.Operation();
    }
}
