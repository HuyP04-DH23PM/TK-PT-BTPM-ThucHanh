
/// <summary>
/// Lớp 'Director' (ConcreteHandler) – duyệt các khoản < 10,000
/// </summary>
public class Director : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 10000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, purchase.Number);
        }
        else if (successor != null)
        {
            // Không duyệt được → chuyển tiếp cho cấp kế tiếp
            successor.ProcessRequest(purchase);
        }
    }
}
