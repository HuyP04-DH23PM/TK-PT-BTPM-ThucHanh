using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo một gói mẫu hữu cơ ban đầu
        ConcretePrototype1 goiHuuCoMau = new ConcretePrototype1("GOI-HC-001");
        goiHuuCoMau.HienThi();

        // Clone từ mẫu hữu cơ
        ConcretePrototype1 goiHuuCoClone = (ConcretePrototype1)goiHuuCoMau.Clone();
        Console.WriteLine("\n🧬 Đã nhân bản một gói hữu cơ mới từ mẫu có sẵn!");
        goiHuuCoClone.HienThi();

        // Tạo một gói mẫu hóa học ban đầu
        ConcretePrototype2 goiHoaHocMau = new ConcretePrototype2("GOI-HH-001");
        goiHoaHocMau.HienThi();

        // Clone từ mẫu hóa học
        ConcretePrototype2 goiHoaHocClone = (ConcretePrototype2)goiHoaHocMau.Clone();
        Console.WriteLine("\n🧬 Đã nhân bản một gói hóa học mới từ mẫu có sẵn!");
        goiHoaHocClone.HienThi();

        Console.ReadKey();
    }
}
