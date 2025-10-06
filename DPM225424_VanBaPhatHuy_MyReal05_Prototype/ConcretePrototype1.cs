using System;

// Prototype cụ thể: Gói Hữu Cơ
public class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(string maGoi)
        : base(maGoi)
    {
    }

    // Clone nông (shallow copy)
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }

    public void HienThi()
    {
        Console.WriteLine($"📋 Gói mẫu (hữu cơ) – Mã: {MaGoi}");
        Console.WriteLine($"   - Phân bón hữu cơ AGU");
        Console.WriteLine($"   - Thuốc sinh học AGU Bio");
    }
}
