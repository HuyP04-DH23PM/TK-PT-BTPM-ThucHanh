using System;

// 'Lion' là một sản phẩm cụ thể (ProductB1)
// Nó kế thừa từ Carnivore (động vật ăn thịt)
class Lion : Carnivore
{
    // Cài đặt phương thức Eat: Sư tử ăn một Herbivore (ví dụ: Wildebeest)
    public override void Eat(Herbivore h)
    {
        Console.WriteLine(this.GetType().Name +
          " eats " + h.GetType().Name);
    }
}
