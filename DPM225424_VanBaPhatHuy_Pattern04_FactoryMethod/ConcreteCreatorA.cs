// 'ConcreteCreatorA' là một lớp tạo sản phẩm cụ thể (Concrete Creator)
// Nó kế thừa từ lớp Creator (lớp cơ sở trong Factory Method Pattern)
class ConcreteCreatorA : Creator
{
    // Ghi đè phương thức FactoryMethod
    // Trả về một đối tượng cụ thể: ConcreteProductA
    public override Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}
