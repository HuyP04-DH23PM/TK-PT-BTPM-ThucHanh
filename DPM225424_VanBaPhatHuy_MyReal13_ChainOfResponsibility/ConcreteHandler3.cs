using System;

/// <summary>
/// Giám đốc cửa hàng: duyệt chiết khấu từ 20–29%
/// </summary>
public class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.WriteLine($"🟢 {GetType().Name} (Giám đốc) duyệt chiết khấu {request}%");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
        else
        {
            // Vượt quyền toàn chuỗi
            Console.WriteLine($"❌ Yêu cầu {request}% vượt quyền. Cần Ban Giám đốc khu vực phê duyệt.");
        }
    }
}
