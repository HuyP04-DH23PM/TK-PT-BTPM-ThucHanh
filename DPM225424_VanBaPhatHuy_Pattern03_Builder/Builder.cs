// 'Builder' là lớp trừu tượng (Abstract Class)
// Nó định nghĩa giao diện chung cho việc xây dựng các phần (Part) của đối tượng phức tạp
abstract class Builder
{
    // Phương thức trừu tượng để xây dựng phần A
    public abstract void BuildPartA();

    // Phương thức trừu tượng để xây dựng phần B
    public abstract void BuildPartB();

    // Phương thức trả về đối tượng hoàn chỉnh sau khi xây dựng xong
    public abstract Product GetResult();
}
