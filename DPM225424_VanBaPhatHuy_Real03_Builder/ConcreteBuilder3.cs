// 'ScooterBuilder' là một ConcreteBuilder (người xây dựng cụ thể)
// Nó kế thừa từ VehicleBuilder và định nghĩa cách xây dựng một chiếc xe tay ga (Scooter)
class ScooterBuilder : VehicleBuilder
{
    // Constructor: khởi tạo đối tượng Vehicle kiểu "Scooter"
    public ScooterBuilder()
    {
        vehicle = new Vehicle("Scooter");
    }

    // Xây khung xe tay ga
    public override void BuildFrame()
    {
        vehicle["frame"] = "Scooter Frame";
    }

    // Xây động cơ (dung tích nhỏ, chỉ 50 cc)
    public override void BuildEngine()
    {
        vehicle["engine"] = "50 cc";
    }

    // Xây bánh xe (xe tay ga có 2 bánh)
    public override void BuildWheels()
    {
        vehicle["wheels"] = "2";
    }

    // Xây cửa xe (xe tay ga không có cửa)
    public override void BuildDoors()
    {
        vehicle["doors"] = "0";
    }
}
