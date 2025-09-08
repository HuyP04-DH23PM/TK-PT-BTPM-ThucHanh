// 'VehicleBuilder' là lớp trừu tượng (Abstract Builder)
// Nó định nghĩa khung để xây dựng từng phần của một chiếc xe (Vehicle)
abstract class VehicleBuilder
{
    // Biến protected lưu trữ đối tượng Vehicle đang được xây dựng
    protected Vehicle vehicle;

    // Thuộc tính chỉ đọc để lấy ra sản phẩm (Vehicle) đã build
    public Vehicle Vehicle
    {
        get { return vehicle; }
    }

    // Các phương thức trừu tượng: 
    // mỗi ConcreteBuilder sẽ cài đặt chi tiết xây dựng các phần khác nhau của xe
    public abstract void BuildFrame();   // Xây khung xe
    public abstract void BuildEngine();  // Xây động cơ
    public abstract void BuildWheels();  // Xây bánh xe
    public abstract void BuildDoors();   // Xây cửa xe
}
