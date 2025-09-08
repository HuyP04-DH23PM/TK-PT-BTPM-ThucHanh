using System.Collections.Generic;

// 'ColorManager' đóng vai trò Prototype Manager
// Nó quản lý tập hợp các prototype (mẫu màu) để có thể clone khi cần
public class ColorManager
{
    // Dictionary lưu trữ các prototype với key là tên màu
    private Dictionary<string, ColorPrototype> colors =
        new Dictionary<string, ColorPrototype>();

    // Indexer: cho phép truy cập và gán prototype theo key
    public ColorPrototype this[string key]
    {
        get { return colors[key]; }          // Lấy prototype theo key
        set { colors.Add(key, value); }      // Thêm prototype mới vào danh sách
    }
}
