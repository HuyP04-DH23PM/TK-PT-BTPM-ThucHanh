/// <summary>
/// Lớp trừu tượng 'Flyweight' (MyReal):
/// - Giữ "intrinsic state" như TênNhóm, ĐơnVịTính (dùng chung, không đổi).
/// - Nhận "extrinsic state" (số lượng) khi thực thi.
/// </summary>
public abstract class Flyweight
{
    protected string TenNhom { get; }
    protected string DonViTinh { get; }

    protected Flyweight(string tenNhom, string donViTinh)
    {
        TenNhom = tenNhom;
        DonViTinh = donViTinh;
    }

    public abstract void Operation(int extrinsicstate);
}
