// 'Carnivore' là lớp trừu tượng (AbstractProductB)
// Đại diện cho nhóm sản phẩm "động vật ăn thịt"
abstract class Carnivore
{
    // Phương thức trừu tượng: động vật ăn thịt sẽ ăn một Herbivore
    public abstract void Eat(Herbivore h);
}
