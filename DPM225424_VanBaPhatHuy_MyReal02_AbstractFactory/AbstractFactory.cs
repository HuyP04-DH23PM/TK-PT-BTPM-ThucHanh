namespace MyReal.AbstractFactory
{
    // Nhà máy nông dược trừu tượng
    abstract class AbstractFactory
    {
        // Tạo ra phân bón
        public abstract AbstractProductA CreateProductA();

        // Tạo ra thuốc trừ sâu
        public abstract AbstractProductB CreateProductB();
    }
}
