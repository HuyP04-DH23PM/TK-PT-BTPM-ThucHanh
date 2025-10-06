using System;

// Prototype cụ thể: Gói Hóa Học
public class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(string maGoi)
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
        Console.WriteLine($"📋 Gói mẫu (hóa học) – Mã: {MaGoi}");
        Console.WriteLine($"   - Phân bón hóa học AGU");
        Console.WriteLine($"   - Thuốc trừ sâu tổng hợp AGU Synth");
    }
}
