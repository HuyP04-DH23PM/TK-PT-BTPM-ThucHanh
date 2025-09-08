using System;

// Demo Prototype Design Pattern với Color Manager
public class Program
{
    public static void Main(string[] args)
    {
        ColorManager colormanager = new ColorManager();

        // Khởi tạo với các màu chuẩn (prototype có sẵn)
        colormanager["red"] = new Color(255, 0, 0);
        colormanager["green"] = new Color(0, 255, 0);
        colormanager["blue"] = new Color(0, 0, 255);

        // Người dùng thêm các màu cá nhân hóa
        colormanager["angry"] = new Color(255, 54, 0);
        colormanager["peace"] = new Color(128, 211, 128);
        colormanager["flame"] = new Color(211, 34, 20);

        // Người dùng clone các màu từ ColorManager
        Color color1 = colormanager["red"].Clone() as Color;
        Color color2 = colormanager["peace"].Clone() as Color;
        Color color3 = colormanager["flame"].Clone() as Color;

        // Dừng console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
