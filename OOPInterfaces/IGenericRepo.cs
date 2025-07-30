namespace OOPInterfaces;

public interface IGenericRepo<T>  where T : class,new()
{
    public void Print();
    public void Set(T item);
    public T GetOne(Func<T,bool> expression);
    public List<T> GetAll();
    public T Delete(Func<T, bool> expression);
}