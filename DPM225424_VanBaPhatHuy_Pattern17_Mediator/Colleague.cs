
/// <summary>
/// Lớp trừu tượng 'Colleague' – cơ sở cho các đối tượng giao tiếp qua Mediator
/// </summary>
public abstract class Colleague
{
    protected Mediator mediator;

    // Hàm khởi tạo: nhận Mediator để liên lạc gián tiếp
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}
