
/// <summary>
/// Lớp 'VicePresident' (ConcreteHandler) – duyệt các khoản < 25,000
/// </summary>
public class VicePresident : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 25000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, purchase.Number);
        }
        else if (successor != null)
        {
            successor.ProcessRequest(purchase);
        }
    }
}
