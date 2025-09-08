using System;

// 'Adaptee' là lớp sẵn có (đã tồn tại) với một interface không tương thích với Client
// Nó có một phương thức riêng biệt là SpecificRequest()
public class Adaptee
{
    // Phương thức đặc thù (không khớp với interface mà Client mong muốn)
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}
