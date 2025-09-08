using Bridge.RealWorld;

// 'CustomersBase' đóng vai trò Abstraction trong Bridge Pattern
// Nó định nghĩa giao diện cấp cao để thao tác với dữ liệu khách hàng
// nhưng việc thực thi thật sự được ủy quyền cho DataObject (Implementor)
public class CustomersBase
{
    // Tham chiếu đến Implementor (DataObject)
    private DataObject dataObject;

    // Thuộc tính để gán/lấy đối tượng DataObject cụ thể
    public DataObject Data
    {
        set { dataObject = value; }
        get { return dataObject; }
    }

    // Các thao tác cấp cao, ủy quyền lại cho DataObject

    public virtual void Next()
    {
        dataObject.NextRecord();
    }

    public virtual void Prior()
    {
        dataObject.PriorRecord();
    }

    public virtual void Add(string customer)
    {
        dataObject.AddRecord(customer);
    }

    public virtual void Delete(string customer)
    {
        dataObject.DeleteRecord(customer);
    }

    public virtual void Show()
    {
        dataObject.ShowRecord();
    }

    public virtual void ShowAll()
    {
        dataObject.ShowAllRecords();
    }
}
