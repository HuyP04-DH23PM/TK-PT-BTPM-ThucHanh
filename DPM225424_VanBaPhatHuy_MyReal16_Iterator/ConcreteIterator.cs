/// <summary>
/// ConcreteIterator – MyReal: cách duyệt tuần tự qua mục đơn
/// </summary>
public class ConcreteIterator : Iterator
{
    private readonly ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override object Next()
    {
        object ret = null;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }
        return ret;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}
