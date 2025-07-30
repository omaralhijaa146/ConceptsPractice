namespace OOPInterfaces;

public interface IGenericRepo<T> :IRepository<T> where T : class,new()
{
    public void Print();
    
}