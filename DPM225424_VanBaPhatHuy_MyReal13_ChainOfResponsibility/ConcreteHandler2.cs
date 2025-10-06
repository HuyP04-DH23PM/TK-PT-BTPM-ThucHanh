using System;

/// <summary>
/// Trưởng ca/Quản lý: duyệt chiết khấu từ 10–19%
/// </summary>
public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine($"✅ {GetType().Name} (Quản lý) duyệt chiết khấu {request}%");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
