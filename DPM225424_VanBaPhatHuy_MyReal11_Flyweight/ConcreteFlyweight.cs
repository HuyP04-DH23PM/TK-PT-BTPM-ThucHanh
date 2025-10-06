using System;

/// <summary>
/// 'ConcreteFlyweight' (MyReal):
/// Mẫu nhãn/gói sản phẩm CHIA SẺ (dùng lại).
/// </summary>
public class ConcreteFlyweight : Flyweight
{
    public ConcreteFlyweight(string tenNhom, string donViTinh)
        : base(tenNhom, donViTinh) { }

    public override void Operation(int extrinsicstate)
    {
        Console.WriteLine($"[SHARED] {TenNhom} → áp dụng cho số lượng: {extrinsicstate} {DonViTinh}");
    }
}
