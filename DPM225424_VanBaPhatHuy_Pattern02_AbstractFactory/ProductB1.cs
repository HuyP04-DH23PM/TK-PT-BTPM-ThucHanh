// 'ProductB1' là một sản phẩm cụ thể thuộc nhóm B
// Nó kế thừa từ AbstractProductB
class ProductB1 : AbstractProductB
{
    // Ghi đè phương thức Interact
    // Cho phép ProductB1 "tương tác" với một sản phẩm thuộc nhóm A
    public override void Interact(AbstractProductA a)
    {
        // In ra màn hình tên lớp (ProductB1) và tên của đối tượng a (ví dụ: ProductA1)
        Console.WriteLine(this.GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}
