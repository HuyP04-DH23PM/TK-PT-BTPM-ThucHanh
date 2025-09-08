using System;

// Demo Builder Pattern trong tình huống thực tế: xây dựng phương tiện
public class MainApp
{
    public static void Main()
    {
        VehicleBuilder builder;

        // Tạo Shop (Director) – chịu trách nhiệm điều phối quá trình xây dựng
        Shop shop = new Shop();

        // Xây dựng và hiển thị Scooter
        builder = new ScooterBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        // Xây dựng và hiển thị Car
        builder = new CarBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        // Xây dựng và hiển thị MotorCycle
        builder = new MotorCycleBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
