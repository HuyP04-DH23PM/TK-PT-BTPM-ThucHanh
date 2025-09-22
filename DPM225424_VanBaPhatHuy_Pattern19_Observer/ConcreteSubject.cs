
/// <summary>
/// Lớp 'ConcreteSubject' – Subject cụ thể, nắm giữ trạng thái cần được các Observer quan sát
/// </summary>
public class ConcreteSubject : Subject
{
    // Trạng thái của Subject
    private string subjectState;

    // Thuộc tính get/set trạng thái Subject
    public string SubjectState
    {
        get { return subjectState; }
        set { subjectState = value; }
    }
}
