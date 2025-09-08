// 'AnimalWorld' đóng vai trò Client trong Abstract Factory Pattern
// Nó sử dụng ContinentFactory để lấy ra các loài động vật mà không cần biết chi tiết lớp cụ thể
class AnimalWorld
{
    private Herbivore _herbivore; // Động vật ăn cỏ
    private Carnivore _carnivore; // Động vật ăn thịt

    // Constructor: nhận vào một ContinentFactory
    // Tùy factory truyền vào (AfricaFactory hoặc AmericaFactory)
    // mà AnimalWorld sẽ có cặp động vật tương ứng
    public AnimalWorld(ContinentFactory factory)
    {
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }

    // Mô phỏng chuỗi thức ăn (Carnivore ăn Herbivore)
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}
