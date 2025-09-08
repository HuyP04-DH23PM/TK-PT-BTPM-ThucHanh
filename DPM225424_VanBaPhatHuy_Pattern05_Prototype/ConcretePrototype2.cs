// 'ConcretePrototype2' là một lớp Prototype cụ thể
// Nó kế thừa từ lớp Prototype
public class ConcretePrototype2 : Prototype
{
    // Constructor nhận vào id và gọi constructor lớp cha (Prototype)
    public ConcretePrototype2(string id)
        : base(id)
    {
    }

    // Phương thức Clone trả về bản sao nông (shallow copy) của đối tượng hiện tại
    // Shallow copy: copy giá trị, nhưng nếu có tham chiếu object thì vẫn dùng chung
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
