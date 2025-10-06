using System.Collections.Generic;

/// <summary>
/// 'Subject' – quản lý danh sách Observer và phát thông báo
/// </summary>
public abstract class Subject
{
    private List<Observer> observers = new List<Observer>();

    public void Attach(Observer observer) => observers.Add(observer);
    public void Detach(Observer observer) => observers.Remove(observer);

    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Update();
        }
    }
}
