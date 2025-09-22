
/// <summary>
/// Lớp trừu tượng Command – định nghĩa giao diện cho các lệnh (có Execute và UnExecute)
/// </summary>
public abstract class Command
{
    public abstract void Execute();    // Thực thi lệnh
    public abstract void UnExecute();  // Hoàn tác lệnh
}
