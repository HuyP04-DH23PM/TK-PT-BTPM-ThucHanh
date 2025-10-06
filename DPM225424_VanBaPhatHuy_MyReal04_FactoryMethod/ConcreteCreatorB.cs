// Nhà máy đóng gói gói hóa học
class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB(); // Gói hóa học
    }
}
