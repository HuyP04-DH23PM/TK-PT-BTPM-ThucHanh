namespace MyReal.AbstractFactory
{
    // Nhà máy sản xuất hóa học
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2(); // Phân bón hóa học
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2(); // Thuốc trừ sâu tổng hợp
        }
    }
}
