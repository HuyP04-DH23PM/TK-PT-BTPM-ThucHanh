using Bridge.Structural;

// 'Abstraction' là lớp trừu tượng (phần giao diện bên ngoài mà Client sử dụng)
// Nó chứa một tham chiếu đến Implementor (phần cài đặt)
public class Abstraction
{
    // Tham chiếu đến Implementor (interface hoặc abstract class)
    protected Implementor implementor;

    // Thuộc tính cho phép gán Implementor cụ thể từ bên ngoài
    public Implementor Implementor
    {
        set { implementor = value; }
    }

    // Phương thức ảo: gọi Operation() của Implementor
    // Abstraction định nghĩa giao diện cấp cao,
    // nhưng việc thực hiện thực sự do Implementor đảm nhận
    public virtual void Operation()
    {
        implementor.Operation();
    }
}
