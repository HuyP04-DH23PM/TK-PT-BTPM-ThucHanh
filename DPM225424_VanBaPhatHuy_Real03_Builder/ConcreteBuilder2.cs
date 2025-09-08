// 'CarBuilder' là một ConcreteBuilder (người xây dựng cụ thể)
// Nó kế thừa từ VehicleBuilder và định nghĩa cách xây dựng một chiếc xe hơi
class CarBuilder : VehicleBuilder
{
    // Constructor: khởi tạo đối tượng Vehicle kiểu "Car"
    public CarBuilder()
    {
        vehicle = new Vehicle("Car");
    }

    // Xây khung xe hơi
    public override void BuildFrame()
    {
        vehicle["frame"] = "Car Frame";
    }

    // Xây động cơ xe hơi
    public override void BuildEngine()
    {
        vehicle["engine"] = "2500 cc";
    }

    // Xây bánh xe (xe hơi có 4 bánh)
    public override void BuildWheels()
    {
        vehicle["wheels"] = "4";
    }

    // Xây cửa xe (xe hơi có 4 cửa)
    public override void BuildDoors()
    {
        vehicle["doors"] = "4";
    }
}
