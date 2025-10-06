using System;

// 'Facade' (MyReal): Giao diện đơn giản hoá để xử lý đơn nông dược
// Ẩn bớt chi tiết: kho, thanh toán, vận chuyển, thông báo
public class Facade
{
    SubSystemOne one;
    SubSystemTwo two;
    SubSystemThree three;
    SubSystemFour four;

    public Facade()
    {
        one = new SubSystemOne();   // Kho
        two = new SubSystemTwo();   // Thanh toán
        three = new SubSystemThree(); // Vận chuyển
        four = new SubSystemFour(); // Thông báo
    }

    // MethodA: luồng “Fullflow” cho gói hữu cơ (kho + thanh toán + thông báo)
    public void MethodA()
    {
        Console.WriteLine("\n🧾 MethodA() — Xử lý đơn GÓI HỮU CƠ (fullflow)");
        one.MethodOne();   // kho
        two.MethodTwo();   // thanh toán
        four.MethodFour(); // thông báo
    }

    // MethodB: luồng “Hậu cần” (thanh toán + tạo vận đơn)
    public void MethodB()
    {
        Console.WriteLine("\n🚚 MethodB() — HẬU CẦN: Thanh toán + Giao hàng");
        two.MethodTwo();     // thanh toán
        three.MethodThree(); // vận chuyển
    }
}
