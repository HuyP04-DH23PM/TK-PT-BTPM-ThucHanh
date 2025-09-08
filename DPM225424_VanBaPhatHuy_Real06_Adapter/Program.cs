using System;

// Demo Adapter Design Pattern: chuyển từ Compound (Target) sang dùng ChemicalDatabank (Adaptee) qua RichCompound (Adapter)
public class Program
{
    public static void Main(string[] args)
    {
        // Hợp chất CHƯA được "thích nghi" (không có dữ liệu thật)
        Compound unknown = new Compound();
        unknown.Display(); // In ra mặc định: Unknown

        // Các hợp chất ĐÃ được "thích nghi" qua Adapter: RichCompound
        // RichCompound sẽ lấy dữ liệu thật từ ChemicalDatabank và hiển thị
        Compound water = new RichCompound("Water");
        water.Display();

        Compound benzene = new RichCompound("Benzene");
        benzene.Display();

        Compound ethanol = new RichCompound("Ethanol");
        ethanol.Display();

        // Dừng console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
