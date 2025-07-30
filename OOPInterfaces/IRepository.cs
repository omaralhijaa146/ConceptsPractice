namespace OOPInterfaces;

public interface IRepository<T>
{
    public void Set(T item);
    public T GetOne(Func<T,bool> expression);
    public List<T> GetAll();
    public T Delete(Func<T, bool> expression);
}