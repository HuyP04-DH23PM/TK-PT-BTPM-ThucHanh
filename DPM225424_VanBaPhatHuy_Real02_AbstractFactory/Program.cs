using System;

class MainApp
{
    public static void Main()
    {
        // Tạo và chạy thế giới động vật châu Phi
        ContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new AnimalWorld(africa);
        world.RunFoodChain(); // Kết quả: Lion eats Wildebeest

        // Tạo và chạy thế giới động vật châu Mỹ
        ContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain(); // Kết quả: Wolf eats Bison

        // Dừng màn hình console chờ người dùng nhấn phím
        Console.ReadKey();
    }
}
