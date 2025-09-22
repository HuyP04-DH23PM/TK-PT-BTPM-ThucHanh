
/// <summary>
/// Lớp trừu tượng 'Mediator' – định nghĩa giao diện chuyển tiếp thông điệp
/// </summary>
public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
