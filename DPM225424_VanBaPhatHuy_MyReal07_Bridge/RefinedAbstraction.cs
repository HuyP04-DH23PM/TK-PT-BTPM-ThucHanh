// Bộ điều khiển thông minh, có thể mở rộng logic điều phối
public class RefinedAbstraction : Abstraction
{
    public override void Operation()
    {
        Console.WriteLine("🧠 Bộ điều khiển trung tâm gửi lệnh tới công nghệ tưới...");
        implementor.Operation();
    }
}
