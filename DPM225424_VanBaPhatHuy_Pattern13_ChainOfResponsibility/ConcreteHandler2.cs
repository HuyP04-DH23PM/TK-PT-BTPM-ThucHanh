using System.Text;

/// <summary>
/// Lớp ConcreteHandler2 – xử lý các yêu cầu từ 10 đến nhỏ hơn 20
/// </summary>
public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        Console.OutputEncoding = Encoding.UTF8;
        if (request >= 10 && request < 20)
        {
            Console.WriteLine("{0} xử lý yêu cầu {1}",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}