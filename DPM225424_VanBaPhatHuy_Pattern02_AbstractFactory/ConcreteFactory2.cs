// 'ConcreteFactory2' cũng kế thừa từ AbstractFactory
// Đây là một "nhà máy cụ thể" khác, tạo ra một họ sản phẩm khác (ProductA2, ProductB2)
class ConcreteFactory2 : AbstractFactory
{
    // Ghi đè phương thức tạo ProductA
    // → lần này CreateProductA sẽ trả về đối tượng ProductA2
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    // Ghi đè phương thức tạo ProductB
    // → lần này CreateProductB sẽ trả về đối tượng ProductB2
    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
