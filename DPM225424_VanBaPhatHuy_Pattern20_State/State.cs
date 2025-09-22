
/// <summary>
/// Lớp trừu tượng 'State' – định nghĩa hành vi xử lý ứng với từng trạng thái
/// </summary>
public abstract class State
{
    // Xử lý yêu cầu trên Context; có thể thay đổi Context.State bên trong
    public abstract void Handle(Context context);
}
