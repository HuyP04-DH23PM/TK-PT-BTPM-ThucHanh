using System;

/// <summary>
/// Nhân viên bán hàng: duyệt chiết khấu từ 0–9%
/// </summary>
public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
        {
            Console.WriteLine($"🧾 {GetType().Name} (Nhân viên bán hàng) duyệt chiết khấu {request}%");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
