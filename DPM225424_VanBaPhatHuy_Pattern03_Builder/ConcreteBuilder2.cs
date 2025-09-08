// 'ConcreteBuilder2' là một lớp cài đặt cụ thể khác (Concrete Builder)
// Nó cũng kế thừa từ Builder, nhưng cách xây dựng sản phẩm khác với ConcreteBuilder1
class ConcreteBuilder2 : Builder
{
    // Biến nội bộ để lưu sản phẩm đang được xây dựng
    private Product _product = new Product();

    // Xây dựng phần A của sản phẩm (khác ConcreteBuilder1: ở đây là "PartX")
    public override void BuildPartA()
    {
        _product.Add("PartX");
    }

    // Xây dựng phần B của sản phẩm (khác ConcreteBuilder1: ở đây là "PartY")
    public override void BuildPartB()
    {
        _product.Add("PartY");
    }

    // Trả về sản phẩm hoàn chỉnh sau khi build xong
    public override Product GetResult()
    {
        return _product;
    }
}
