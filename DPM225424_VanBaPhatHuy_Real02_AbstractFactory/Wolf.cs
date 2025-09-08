using System;

// 'Wolf' là một sản phẩm cụ thể (ProductB2)
// Nó kế thừa từ Carnivore (động vật ăn thịt)
class Wolf : Carnivore
{
    // Cài đặt phương thức Eat: Sói ăn một Herbivore (ví dụ: Bison)
    public override void Eat(Herbivore h)
    {
        Console.WriteLine(this.GetType().Name +
          " eats " + h.GetType().Name);
    }
}
