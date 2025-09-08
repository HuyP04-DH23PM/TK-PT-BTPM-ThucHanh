// 'Component' là lớp trừu tượng (abstract class) trong Composite Pattern
// Nó định nghĩa giao diện chung cho cả Leaf và Composite
public abstract class Component
{
    // Phương thức trừu tượng Operation
    // Các lớp con (Leaf, Composite) sẽ cài đặt chi tiết
    public abstract void Operation();
}
