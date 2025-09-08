// 'RefinedAbstraction' là lớp mở rộng (subclass) của Abstraction
// Nó có thể bổ sung hoặc tùy chỉnh cách gọi đến Implementor
public class RefinedAbstraction : Abstraction
{
    // Ghi đè phương thức Operation
    // Vẫn ủy quyền cho Implementor thực hiện, 
    // nhưng lớp này có thể thêm logic riêng nếu cần
    public override void Operation()
    {
        implementor.Operation();
    }
}
