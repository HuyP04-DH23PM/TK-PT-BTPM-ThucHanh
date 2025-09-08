using System;
using System.Collections.Generic;

// 'Vehicle' là lớp sản phẩm (Product)
// Nó biểu diễn một phương tiện được xây dựng bởi VehicleBuilder
class Vehicle
{
    // Loại phương tiện (Car, MotorCycle, Scooter,…)
    private string _vehicleType;

    // Danh sách các bộ phận (frame, engine, wheels, doors,…)
    private Dictionary<string, string> _parts =
      new Dictionary<string, string>();

    // Constructor: khởi tạo với loại phương tiện
    public Vehicle(string vehicleType)
    {
        this._vehicleType = vehicleType;
    }

    // Indexer: cho phép truy cập và gán giá trị cho các bộ phận theo key
    public string this[string key]
    {
        get { return _parts[key]; }
        set { _parts[key] = value; }
    }

    // Hiển thị thông tin chi tiết của phương tiện
    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Vehicle Type: {0}", _vehicleType);
        Console.WriteLine(" Frame : {0}", _parts["frame"]);
        Console.WriteLine(" Engine : {0}", _parts["engine"]);
        Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
        Console.WriteLine(" #Doors : {0}", _parts["doors"]);
    }
}
