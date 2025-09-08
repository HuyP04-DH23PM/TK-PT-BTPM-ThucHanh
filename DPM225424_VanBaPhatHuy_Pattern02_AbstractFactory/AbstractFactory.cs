abstract class AbstractFactory
{
    // Phương thức trừu tượng để tạo ra sản phẩm loại A
    // Mỗi Factory cụ thể sẽ hiện thực (implement) cách tạo ProductA theo ý của nó
    public abstract AbstractProductA CreateProductA();

    // Phương thức trừu tượng để tạo ra sản phẩm loại B
    // Tương tự, mỗi Factory cụ thể sẽ tạo ProductB theo cách riêng
    public abstract AbstractProductB CreateProductB();
}
