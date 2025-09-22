
/// <summary>
/// Lớp 'President' (ConcreteHandler) – duyệt các khoản < 100,000; lớn hơn yêu cầu họp lãnh đạo
/// </summary>
public class President : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 100000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, purchase.Number);
        }
        else
        {
            // Vượt ngưỡng tối đa → yêu cầu cuộc họp lãnh đạo để quyết định
            Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                purchase.Number);
        }
    }
}
