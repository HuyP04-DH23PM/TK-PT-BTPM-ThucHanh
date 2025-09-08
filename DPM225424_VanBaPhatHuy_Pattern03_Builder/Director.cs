// 'Director' là lớp chịu trách nhiệm "chỉ huy" quá trình xây dựng sản phẩm
// Nó định nghĩa thứ tự gọi các bước (BuildPartA, BuildPartB) nhưng KHÔNG quan tâm chi tiết bên trong
class Director
{
    // Phương thức Construct nhận vào một Builder (cụ thể nào đó)
    // và gọi tuần tự các bước để tạo ra sản phẩm hoàn chỉnh
    public void Construct(Builder builder)
    {
        builder.BuildPartA(); // Gọi xây dựng phần A
        builder.BuildPartB(); // Gọi xây dựng phần B
    }
}
