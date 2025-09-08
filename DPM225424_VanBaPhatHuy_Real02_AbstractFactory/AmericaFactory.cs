// 'AmericaFactory' là một ConcreteFactory (nhà máy cụ thể)
// Nó kế thừa từ ContinentFactory và tạo ra các loài động vật thuộc châu Mỹ
class AmericaFactory : ContinentFactory
{
    // Trả về động vật ăn cỏ (Herbivore) cụ thể: Bò rừng (Bison)
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }

    // Trả về động vật ăn thịt (Carnivore) cụ thể: Sói (Wolf)
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}
