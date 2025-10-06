using System;
using System.Text;

/// <summary>
/// Chuỗi trách nhiệm MyReal: phê duyệt chiết khấu đơn hàng nông dược
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Thiết lập chuỗi phê duyệt: Nhân viên → Quản lý → Giám đốc
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();
        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);

        // % chiết khấu yêu cầu (ví dụ)
        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 /*, 31*/ };

        Console.WriteLine("🌿 BẮT ĐẦU PHÊ DUYỆT CHIẾT KHẤU:");
        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }

        // Ví dụ thêm: yêu cầu vượt quyền toàn chuỗi
        // h1.HandleRequest(31);

        Console.WriteLine("\nHoàn tất. Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
