// Builder cụ thể: xây dựng gói sản phẩm canh tác hóa học
class ConcreteBuilder2 : Builder
{
    private Product _product = new Product();

    public override void BuildPhanBon()
    {
        _product.Add("Phân bón hóa học AGU");
    }

    public override void BuildThuocTruSau()
    {
        _product.Add("Thuốc trừ sâu tổng hợp AGU Synth");
    }

    public override Product GetResult()
    {
        return _product;
    }
}
