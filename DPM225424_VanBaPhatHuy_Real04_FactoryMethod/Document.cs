using System.Collections.Generic;

// 'Document' là lớp trừu tượng (Creator)
// Nó khai báo Factory Method để tạo ra các đối tượng Page
abstract class Document
{
    // Danh sách các trang (Page) thuộc về Document
    private List<Page> _pages = new List<Page>();

    // Constructor gọi Factory Method để khởi tạo các trang
    public Document()
    {
        this.CreatePages();
    }

    // Thuộc tính Pages: trả về danh sách các trang
    public List<Page> Pages
    {
        get { return _pages; }
    }

    // Factory Method: sẽ được lớp con override để tạo ra các Page cụ thể
    public abstract void CreatePages();
}
