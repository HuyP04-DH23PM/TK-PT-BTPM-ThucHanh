// 'Prototype' là lớp trừu tượng trong Prototype Pattern
// Nó định nghĩa giao diện chung cho các Prototype cụ thể (ConcretePrototype1, ConcretePrototype2)
public abstract class Prototype
{
    // Thuộc tính id để định danh đối tượng
    string id;

    // Constructor: khởi tạo Prototype với một id
    public Prototype(string id)
    {
        this.id = id;
    }

    // Thuộc tính chỉ đọc (read-only) để lấy id
    public string Id
    {
        get { return id; }
    }

    // Phương thức trừu tượng Clone
    // Các lớp con sẽ hiện thực chi tiết cách clone (sao chép) chính nó
    public abstract Prototype Clone();
}
