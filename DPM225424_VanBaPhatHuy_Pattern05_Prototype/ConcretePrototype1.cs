// 'ConcretePrototype1' là một lớp Prototype cụ thể
// Nó kế thừa từ lớp Prototype
public class ConcretePrototype1 : Prototype
{
    // Constructor nhận vào id và gọi constructor của lớp cha (Prototype)
    public ConcretePrototype1(string id)
        : base(id)
    {
    }

    // Phương thức Clone trả về bản sao nông (shallow copy) của đối tượng hiện tại
    // Shallow copy: chỉ copy các giá trị, tham chiếu bên trong vẫn trỏ cùng object
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
