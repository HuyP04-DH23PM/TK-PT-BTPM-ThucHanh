// 'Creator' là lớp trừu tượng (Abstract Class) trong Factory Method Pattern
// Nó khai báo phương thức FactoryMethod nhưng không cài đặt chi tiết
abstract class Creator
{
    // Phương thức trừu tượng để tạo ra Product
    // Các lớp con (ConcreteCreatorA, ConcreteCreatorB) sẽ override và quyết định tạo ra sản phẩm cụ thể nào
    public abstract Product FactoryMethod();
}
