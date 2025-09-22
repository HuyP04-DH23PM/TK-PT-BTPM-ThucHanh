using System.Text;

/// <summary>
/// Lớp ConcreteHandler1 – xử lý các yêu cầu từ 0 đến nhỏ hơn 10
/// </summary>
public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        Console.OutputEncoding = Encoding.UTF8;
        if (request >= 0 && request < 10)
        {
            Console.WriteLine("{0} xử lý yêu cầu {1}",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            // Nếu không xử lý được, chuyển tiếp cho Handler kế tiếp
            successor.HandleRequest(request);
        }
    }
}