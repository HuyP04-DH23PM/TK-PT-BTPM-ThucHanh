// 'Adapter' là lớp cầu nối (chuyển đổi) giữa Target và Adaptee
// Nó kế thừa từ Target để đảm bảo tương thích với Client
public class Adapter : Target
{
    // Tham chiếu đến Adaptee (lớp có sẵn nhưng không khớp interface)
    private Adaptee adaptee = new Adaptee();

    // Ghi đè phương thức Request mà Client mong muốn
    public override void Request()
    {
        // Có thể xử lý bổ sung ở đây trước khi gọi Adaptee
        // Sau đó gọi phương thức SpecificRequest() của Adaptee
        adaptee.SpecificRequest();
    }
}
