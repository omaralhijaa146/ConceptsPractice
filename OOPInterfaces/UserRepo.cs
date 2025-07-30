using OOPInterfaces.Models;

namespace OOPInterfaces;

public class UserRepo:GenericRepo<User>,IUserRepo,IPrintable
{
    public UserRepo(List<User> list) : base(list)
    { }
    
    void IPrintable.Print() {
        Console.WriteLine("Explicit Print Method");
        base.Print();
        Console.WriteLine("Explicit Print Method");
    }

    public void Print()
    {
        Console.WriteLine("Re-implemented Print Method");
        base.Print();
        Console.WriteLine("Re-implemented Print Method");
    }
}