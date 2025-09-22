using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo đối tượng Facade (Mortgage)
        Mortgage mortgage = new Mortgage();

        // Tạo khách hàng cần vay tiền
        Customer customer = new Customer("Ann McKinsey");

        // Kiểm tra điều kiện vay cho khách hàng với số tiền 125,000
        bool eligible = mortgage.IsEligible(customer, 125000);

        // Thông báo kết quả: Được duyệt hay bị từ chối
        Console.WriteLine("\n" + customer.Name +
                " đã được " + (eligible ? "DUYỆT" : "TỪ CHỐI"));

        // Dừng màn hình, chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
