using System;

// 'Color' là một ConcretePrototype (nguyên mẫu cụ thể)
// Nó kế thừa từ ColorPrototype và cho phép nhân bản chính nó
public class Color : ColorPrototype
{
    int red;
    int green;
    int blue;

    // Constructor: khởi tạo với giá trị màu RGB
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    // Phương thức Clone: tạo một bản sao nông (shallow copy) của đối tượng hiện tại
    public override ColorPrototype Clone()
    {
        Console.WriteLine(
            "Cloning color RGB: {0,3},{1,3},{2,3}",
            red, green, blue);

        // MemberwiseClone() tạo bản sao nông → copy giá trị các trường
        return this.MemberwiseClone() as ColorPrototype;
    }
}
