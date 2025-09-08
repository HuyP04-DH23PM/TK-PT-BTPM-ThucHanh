// 'MotorCycleBuilder' là một ConcreteBuilder (người xây dựng cụ thể)
// Nó kế thừa từ VehicleBuilder và định nghĩa cách xây dựng một chiếc xe máy
class MotorCycleBuilder : VehicleBuilder
{
    // Constructor: khởi tạo đối tượng Vehicle kiểu "MotorCycle"
    public MotorCycleBuilder()
    {
        vehicle = new Vehicle("MotorCycle");
    }

    // Xây khung xe
    public override void BuildFrame()
    {
        vehicle["frame"] = "MotorCycle Frame";
    }

    // Xây động cơ
    public override void BuildEngine()
    {
        vehicle["engine"] = "500 cc";
    }

    // Xây bánh xe (xe máy có 2 bánh)
    public override void BuildWheels()
    {
        vehicle["wheels"] = "2";
    }

    // Xây cửa xe (xe máy không có cửa)
    public override void BuildDoors()
    {
        vehicle["doors"] = "0";
    }
}
