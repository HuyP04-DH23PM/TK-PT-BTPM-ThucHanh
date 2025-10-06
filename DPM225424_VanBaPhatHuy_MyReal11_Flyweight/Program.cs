using System;
using System.Text;

/// <summary>
/// Demo Flyweight (MyReal) – cửa hàng nông dược
/// Intrinsic: tên nhóm + đơn vị; Extrinsic: số lượng.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int soLuong = 80;

        var factory = new FlyweightFactory();

        // Dùng các mẫu CHIA SẺ (tái sử dụng instance theo key)
        var fwHuuCo = factory.GetFlyweight("HUUCO");
        fwHuuCo.Operation(--soLuong);     // 79

        var fwHoaHoc = factory.GetFlyweight("HOAHOC");
        fwHoaHoc.Operation(--soLuong);    // 78

        var fwSinhHoc = factory.GetFlyweight("SINHHOC");
        fwSinhHoc.Operation(--soLuong);   // 77

        // Mẫu KHÔNG CHIA SẺ (đơn tuỳ chỉnh theo chiến dịch)
        var fwCustom = new UnsharedConcreteFlyweight("Khuyến mãi mùa vụ lúa Hè-Thu");
        fwCustom.Operation(--soLuong);    // 76

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}
