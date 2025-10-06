/// <summary>
/// Lớp trừu tượng 'State' – định nghĩa hành vi theo từng trạng thái
/// </summary>
public abstract class State
{
    // Tên hiển thị thân thiện (MyReal)
    public abstract string Ten { get; }

    // Xử lý yêu cầu trên Context; có thể thay đổi Context.State
    public abstract void Handle(Context context);
}
