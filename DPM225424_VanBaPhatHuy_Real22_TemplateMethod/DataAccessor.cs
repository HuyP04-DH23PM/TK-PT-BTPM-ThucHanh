
/// <summary>
/// Lớp trừu tượng 'DataAccessor' – khai báo các bước của quy trình truy cập/ xử lý dữ liệu
/// </summary>
public abstract class DataAccessor
{
    public abstract void Connect();            // Kết nối (khởi tạo nguồn dữ liệu)
    public abstract void Select();             // Truy vấn/đổ dữ liệu
    public abstract void Process(int top);     // Xử lý/hiển thị 'top' phần tử đầu tiên
    public abstract void Disconnect();         // Ngắt kết nối/giải phóng tài nguyên

    // 'Template Method' – ấn định thứ tự các bước cố định của thuật toán
    public void Run(int top)
    {
        Connect();
        Select();
        Process(top);
        Disconnect();
    }
}
