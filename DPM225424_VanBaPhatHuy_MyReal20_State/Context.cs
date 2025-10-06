using System;

/// <summary>
/// 'Context' – nắm giữ trạng thái hiện tại và ủy quyền xử lý cho trạng thái
/// </summary>
public class Context
{
    private State state;

    public Context(State state)
    {
        this.State = state;
    }

    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine($"➡️  Trạng thái hiện tại: {state.Ten} ({state.GetType().Name})");
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}
