// 'ConcreteCreatorB' là một lớp tạo sản phẩm cụ thể (Concrete Creator)
// Nó kế thừa từ lớp Creator trong Factory Method Pattern
class ConcreteCreatorB : Creator
{
    // Ghi đè phương thức FactoryMethod
    // Trả về một đối tượng cụ thể: ConcreteProductB
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}
