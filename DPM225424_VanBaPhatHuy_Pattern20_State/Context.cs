
/// <summary>
/// Lớp 'Context' – nắm giữ trạng thái hiện tại và ủy quyền xử lý cho trạng thái
/// </summary>
public class Context
{
    // Trạng thái hiện tại
    State state;

    // Hàm khởi tạo – thiết lập trạng thái ban đầu
    public Context(State state)
    {
        this.State = state;
    }

    // Thuộc tính get/set trạng thái; khi set sẽ log ra tên trạng thái mới
    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("Trạng thái: " + state.GetType().Name);
        }
    }

    // Nhận yêu cầu từ bên ngoài và ủy quyền cho trạng thái hiện tại xử lý
    public void Request()
    {
        state.Handle(this);
    }
}
