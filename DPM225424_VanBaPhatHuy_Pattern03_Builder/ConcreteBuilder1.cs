// 'ConcreteBuilder1' là lớp cài đặt cụ thể (Concrete Builder)
// Nó kế thừa từ Builder và định nghĩa cách xây dựng từng phần của Product
class ConcreteBuilder1 : Builder
{
    // Biến nội bộ lưu trữ sản phẩm đang được xây dựng
    private Product _product = new Product();

    // Xây dựng phần A của sản phẩm
    public override void BuildPartA()
    {
        _product.Add("PartA");
    }

    // Xây dựng phần B của sản phẩm
    public override void BuildPartB()
    {
        _product.Add("PartB");
    }

    // Trả về sản phẩm hoàn chỉnh sau khi đã build xong
    public override Product GetResult()
    {
        return _product;
    }
}
