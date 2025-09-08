// 'Implementor' là lớp trừu tượng (abstract class) trong Bridge Pattern
// Nó định nghĩa giao diện cấp thấp (low-level interface) cho các lớp cài đặt cụ thể
public abstract class Implementor
{
    // Phương thức trừu tượng Operation
    // Các lớp ConcreteImplementorA, ConcreteImplementorB sẽ override và hiện thực chi tiết
    public abstract void Operation();
}
