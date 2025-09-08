// 'AfricaFactory' là một ConcreteFactory (nhà máy cụ thể)
// Nó kế thừa từ ContinentFactory và tạo ra các loài động vật thuộc châu Phi
class AfricaFactory : ContinentFactory
{
    // Trả về động vật ăn cỏ (Herbivore) cụ thể: Linh dương (Wildebeest)
    public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }

    // Trả về động vật ăn thịt (Carnivore) cụ thể: Sư tử (Lion)
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}
