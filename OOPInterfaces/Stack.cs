namespace OOPInterfaces;

public class Stack<T>:IPoppable<T>,IPushable<T>
{
    private readonly List<T> _list;
    
    public Stack()
    {
        _list = new List<T>();
    }
    
    public Stack(List<T> list)
    {
        _list = list;
    }
    
    public T Pop()
    { 
        if (_list.Count == 0)
            throw new NullReferenceException();
        
        var item = _list.First();
        _list.Remove(item);
        return item;
    }

    public void Push(T item)
    {
       _list.Add(item);
    }

    public void Print()
    {
        foreach (var item in _list)
            Console.WriteLine(item.ToString());
    }
}

public interface IPoppable<out T>
{
    T Pop();
}

public interface IPushable<in T>
{
    void Push(T item);
}

