using System;

// 'Facade' cung cấp giao diện đơn giản hóa để làm việc với nhiều subsystem phức tạp
public class Facade
{
    // Các subsystem nội bộ
    SubSystemOne one;
    SubSystemTwo two;
    SubSystemThree three;
    SubSystemFour four;

    // Constructor khởi tạo toàn bộ subsystem
    public Facade()
    {
        one = new SubSystemOne();
        two = new SubSystemTwo();
        three = new SubSystemThree();
        four = new SubSystemFour();
    }

    // Phương thức đơn giản hóa cho client (ẩn đi chi tiết gọi subsystem)
    public void MethodA()
    {
        Console.WriteLine("\nMethodA() ---- ");
        one.MethodOne();
        two.MethodTwo();
        four.MethodFour();
    }

    // Một phương thức khác, cũng gom lại các lời gọi subsystem
    public void MethodB()
    {
        Console.WriteLine("\nMethodB() ---- ");
        two.MethodTwo();
        three.MethodThree();
    }
}
