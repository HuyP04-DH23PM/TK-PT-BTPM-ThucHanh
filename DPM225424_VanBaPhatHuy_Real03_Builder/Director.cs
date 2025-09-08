// 'Shop' đóng vai trò Director trong Builder Pattern
// Nó biết trình tự các bước để xây dựng một chiếc xe,
// nhưng không biết chi tiết từng loại xe được xây thế nào
class Shop
{
    // Phương thức Construct nhận vào một VehicleBuilder cụ thể
    // và gọi tuần tự các bước để xây dựng xe
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
    }
}
