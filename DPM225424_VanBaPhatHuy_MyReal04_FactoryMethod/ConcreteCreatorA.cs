// Nhà máy đóng gói gói hữu cơ
class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductA(); // Gói hữu cơ
    }
}
