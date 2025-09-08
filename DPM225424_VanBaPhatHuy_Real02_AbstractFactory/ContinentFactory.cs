// 'ContinentFactory' là lớp trừu tượng (AbstractFactory)
// Nó định nghĩa giao diện cho việc tạo ra các loài động vật của từng châu lục
abstract class ContinentFactory
{
    // Tạo ra một Herbivore (động vật ăn cỏ)
    public abstract Herbivore CreateHerbivore();

    // Tạo ra một Carnivore (động vật ăn thịt)
    public abstract Carnivore CreateCarnivore();
}
