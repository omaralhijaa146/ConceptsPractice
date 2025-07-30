using OOPInterfaces;

/// <summary>
/// <remarks>This Repo allow overriding the interface (implementing it virtually)</remarks>
/// <remarks>This implementation allow the sub class to override the method and customize it</remarks>
/// </summary>
public class GenericRepoAllowOverriding<T>:IGenericRepo<T> where T : class,new()
{

    private readonly List<T> _list;

    public GenericRepoAllowOverriding(List<T> list)
    {
        _list = list;
    }

    public virtual void Print()
    {
        foreach (var item in _list)
            Console.WriteLine(item.ToString());
    }

    public virtual void Set(T item)
    {
        _list.Add(item);
    }

    public virtual T GetOne(Func<T,bool> expression)
    {
        return _list.Where(expression).FirstOrDefault()?? throw new NullReferenceException();
    }

    public virtual List<T> GetAll()
    {
        return _list.Select(x => x).ToList();
    }

    public virtual T Delete(Func<T, bool> expression)
    {
        var item= _list.FirstOrDefault(expression)??throw new NullReferenceException();
        _list.Remove(item);
        return item;
    }
}