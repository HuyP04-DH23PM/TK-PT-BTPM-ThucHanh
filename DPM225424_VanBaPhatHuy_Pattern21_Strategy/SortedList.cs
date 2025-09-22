
/// <summary>
/// Lớp ngữ cảnh 'SortedList' – giữ dữ liệu và ủy quyền sắp xếp cho chiến lược hiện tại
/// </summary>
public class SortedList
{
    // Danh sách cần sắp xếp
    private List<string> list = new List<string>();

    // Chiến lược sắp xếp hiện tại
    private SortStrategy sortstrategy;

    // Thiết lập chiến lược
    public void SetSortStrategy(SortStrategy sortstrategy)
    {
        this.sortstrategy = sortstrategy;
    }

    // Thêm phần tử vào danh sách
    public void Add(string name)
    {
        list.Add(name);
    }

    // Thực thi sắp xếp bằng chiến lược hiện tại và in kết quả
    public void Sort()
    {
        sortstrategy.Sort(list);

        // Duyệt qua danh sách và hiển thị kết quả
        foreach (string name in list)
        {
            Console.WriteLine(" " + name);
        }
        Console.WriteLine();
    }
}
