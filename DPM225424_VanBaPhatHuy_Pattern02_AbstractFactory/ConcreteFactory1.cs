// 'ConcreteFactory1' kế thừa từ AbstractFactory
// Đây là một "nhà máy cụ thể" sẽ tạo ra một họ sản phẩm cụ thể (ProductA1, ProductB1)
class ConcreteFactory1 : AbstractFactory
{
    // Ghi đè phương thức tạo ProductA
    // → mỗi lần gọi CreateProductA sẽ trả về đối tượng ProductA1
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    // Ghi đè phương thức tạo ProductB
    // → mỗi lần gọi CreateProductB sẽ trả về đối tượng ProductB1
    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
