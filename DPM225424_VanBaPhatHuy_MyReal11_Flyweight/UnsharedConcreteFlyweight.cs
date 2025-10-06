using System;

/// <summary>
/// 'UnsharedConcreteFlyweight' (MyReal):
/// Mẫu KHÔNG CHIA SẺ (đơn tuỳ chỉnh theo chiến dịch, lô đặc biệt).
/// </summary>
public class UnsharedConcreteFlyweight : Flyweight
{
    public UnsharedConcreteFlyweight(string moTa)
        : base($"Gói tuỳ chỉnh: {moTa}", "đv tuỳ chỉnh") { }

    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine($"[UNSHARED] {TenNhom} → số lượng: {extrinsicstate}");
    }
}
