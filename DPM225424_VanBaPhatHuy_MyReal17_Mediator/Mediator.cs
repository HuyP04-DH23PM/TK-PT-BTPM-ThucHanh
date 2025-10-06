/// <summary>
/// 'Mediator' – định nghĩa giao diện trung gian chuyển tiếp thông điệp
/// </summary>
public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
