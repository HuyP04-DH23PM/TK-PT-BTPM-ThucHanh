// 'ProductB2' là một sản phẩm cụ thể (Concrete Product) thuộc nhóm B
// Nó kế thừa từ lớp trừu tượng AbstractProductB
class ProductB2 : AbstractProductB
{
    // Ghi đè phương thức Interact
    // Cho phép ProductB2 "tương tác" với một sản phẩm thuộc nhóm A (ví dụ: ProductA2)
    public override void Interact(AbstractProductA a)
    {
        // Xuất ra màn hình tên lớp hiện tại (ProductB2) 
        // và tên lớp của đối tượng a (ví dụ: ProductA2)
        Console.WriteLine(this.GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}
