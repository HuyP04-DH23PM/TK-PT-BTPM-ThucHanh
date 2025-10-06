// Builder cụ thể: xây dựng gói sản phẩm canh tác hữu cơ
class ConcreteBuilder1 : Builder
{
    private Product _product = new Product();

    public override void BuildPhanBon()
    {
        _product.Add("Phân bón hữu cơ AGU");
    }

    public override void BuildThuocTruSau()
    {
        _product.Add("Thuốc sinh học AGU Bio");
    }

    public override Product GetResult()
    {
        return _product;
    }
}
