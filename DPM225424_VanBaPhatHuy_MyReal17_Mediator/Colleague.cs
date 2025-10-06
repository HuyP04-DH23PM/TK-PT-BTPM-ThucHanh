/// <summary>
/// Lớp trừu tượng 'Colleague' – cơ sở cho các đối tượng giao tiếp qua Mediator
/// (MyReal: các bộ phận trong cửa hàng nông dược, ví dụ: Quầy bán hàng, Kho)
/// </summary>
public abstract class Colleague
{
    protected Mediator mediator;

    protected Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}
