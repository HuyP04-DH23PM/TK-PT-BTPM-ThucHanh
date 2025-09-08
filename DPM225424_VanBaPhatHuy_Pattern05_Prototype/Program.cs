using System;

// Demo Prototype Design Pattern
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một Prototype1 với id = "I"
        ConcretePrototype1 p1 = new ConcretePrototype1("I");

        // Clone (sao chép) từ p1 → tạo ra đối tượng c1
        ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        Console.WriteLine("Cloned: {0}", c1.Id); // In ra ID của clone

        // Tạo một Prototype2 với id = "II"
        ConcretePrototype2 p2 = new ConcretePrototype2("II");

        // Clone (sao chép) từ p2 → tạo ra đối tượng c2
        ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
        Console.WriteLine("Cloned: {0}", c2.Id); // In ra ID của clone

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
