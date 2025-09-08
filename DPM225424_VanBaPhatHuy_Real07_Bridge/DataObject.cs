// 'DataObject' là lớp trừu tượng (Implementor) trong Bridge Pattern
// Nó định nghĩa giao diện thao tác với dữ liệu khách hàng
public abstract class DataObject
{
    // Chuyển đến bản ghi kế tiếp
    public abstract void NextRecord();

    // Quay về bản ghi trước đó
    public abstract void PriorRecord();

    // Thêm bản ghi mới (khách hàng mới)
    public abstract void AddRecord(string name);

    // Xóa bản ghi (khách hàng)
    public abstract void DeleteRecord(string name);

    // Lấy bản ghi hiện tại
    public abstract string GetCurrentRecord();

    // Hiển thị bản ghi hiện tại
    public abstract void ShowRecord();

    // Hiển thị tất cả bản ghi
    public abstract void ShowAllRecords();
}
