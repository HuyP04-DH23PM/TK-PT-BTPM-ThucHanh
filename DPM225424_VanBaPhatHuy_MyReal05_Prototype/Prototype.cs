// Prototype: lớp trừu tượng cho các mẫu gói nông dược
public abstract class Prototype
{
    private string _maGoi;

    // Constructor: khởi tạo Prototype với mã gói
    protected Prototype(string maGoi)
    {
        _maGoi = maGoi;
    }

    // Thuộc tính chỉ đọc
    public string MaGoi => _maGoi;

    // Clone: tạo bản sao của mẫu gói
    public abstract Prototype Clone();
}
