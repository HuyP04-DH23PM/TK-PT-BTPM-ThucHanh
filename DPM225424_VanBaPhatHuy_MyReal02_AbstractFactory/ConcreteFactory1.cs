namespace MyReal.AbstractFactory
{
    // Nhà máy sản xuất hữu cơ
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1(); // Phân bón hữu cơ
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1(); // Thuốc sinh học
        }
    }
}
