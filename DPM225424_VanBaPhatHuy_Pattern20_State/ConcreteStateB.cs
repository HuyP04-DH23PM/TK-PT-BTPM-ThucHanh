
/// <summary>
/// Trạng thái cụ thể B
/// </summary>
public class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        // Từ B chuyển sang A
        context.State = new ConcreteStateA();
    }
}
