namespace OOPInterfaces;


/// <summary>
/// <remarks>This Repo does not allow overriding the interface interface(Implicitly implementing the members) This implementiation doesnt allow subclasses to override the methods and customize it since implicitly implementing interfaxce members marks them as sealed by default</remarks>
/// </summary>
public class GenericRepo<T>:IGenericRepo<T> where T : class,new()
{

    private readonly List<T> _list;

    public GenericRepo(List<T> list)
    {
        _list = list;
    }

    public void Print()
    {
        foreach (var item in _list)
            Console.WriteLine(item.ToString());
    }

    public void Set(T item)
    {
       _list.Add(item);
    }

    public T GetOne(Func<T,bool> expression)
    {
        return _list.Where(expression).FirstOrDefault()?? throw new NullReferenceException();
    }

    public List<T> GetAll()
    {
        return _list.Select(x => x).ToList();
    }

    public T Delete(Func<T, bool> expression)
    {
        var item= _list.FirstOrDefault(expression)??throw new NullReferenceException();
        _list.Remove(item);
        return item;
    }
}