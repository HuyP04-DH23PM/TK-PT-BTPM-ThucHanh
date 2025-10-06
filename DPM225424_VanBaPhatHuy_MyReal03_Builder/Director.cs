// Chỉ huy quá trình xây dựng gói sản phẩm
class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPhanBon();
        builder.BuildThuocTruSau();
    }
}
