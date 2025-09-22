
/// <summary>
/// Trạng thái cụ thể A
/// </summary>
public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        // Từ A chuyển sang B
        context.State = new ConcreteStateB();
    }
}
