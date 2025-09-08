using System;

// 'Target' là lớp (hoặc interface) mà Client mong muốn làm việc cùng
// Nó định nghĩa sẵn phương thức Request() theo đúng chuẩn mà Client cần
public class Target
{
    // Phương thức Request có thể được ghi đè (virtual)
    // Client sẽ gọi phương thức này, thay vì gọi trực tiếp vào Adaptee
    public virtual void Request()
    {
        Console.WriteLine("Called Target Request()");
    }
}
