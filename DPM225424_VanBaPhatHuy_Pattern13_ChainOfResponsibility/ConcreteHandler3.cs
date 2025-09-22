using System.Text;

/// <summary>
/// Lớp ConcreteHandler3 – xử lý các yêu cầu từ 20 đến nhỏ hơn 30
/// </summary>
public class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0} xử lý yêu cầu {1}",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}