using OOPInterfaces.Models;

namespace OOPInterfaces;

public class UserRepoOverridesGeneric:GenericRepoAllowOverriding<User>,IUserRepo
{
    public UserRepoOverridesGeneric(List<User> list) : base(list)
    { }

    public override void Print()
    {
        Console.WriteLine("Overriden Print Method");
        base.Print();
        Console.WriteLine("Overriden Print Method");
    }
    
    public override void Set(User item)
    {
        item.Address = "Testing Address are not important";
        base.Set(item);
    }
    
}