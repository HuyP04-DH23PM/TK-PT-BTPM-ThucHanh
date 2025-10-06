using System;
using System.Text;

public class MainApp
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Director director = new Director();

        Builder goiHuuCo = new ConcreteBuilder1();
        Builder goiHoaHoc = new ConcreteBuilder2();

        // Xây dựng gói hữu cơ
        director.Construct(goiHuuCo);
        Product p1 = goiHuuCo.GetResult();
        Console.WriteLine("\n🌿 Gói canh tác hữu cơ đã xây dựng xong:");
        p1.Show();

        // Xây dựng gói hóa học
        director.Construct(goiHoaHoc);
        Product p2 = goiHoaHoc.GetResult();
        Console.WriteLine("\n🧪 Gói canh tác hóa học đã xây dựng xong:");
        p2.Show();

        Console.ReadKey();
    }
}
