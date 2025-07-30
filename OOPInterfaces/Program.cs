using OOPInterfaces.Models;

namespace OOPInterfaces;

class Program
{
    static void Main(string[] args)
    {
        /*// ***********************************************
        // using the implicit interface implementation repo
        var genericRepo = new GenericRepo<User>(SeedUsers());
        genericRepo.Print();
        
        genericRepo.Set(new User
        {
            Id = 5,
            FirstName = "John222",
            LastName = "Doe3333",
            Address = "N/A",
            PhoneNumber = "4445556667"
        });
        
        genericRepo.Print();
        
        var userRepo = new UserRepo(SeedUsers());
        
        userRepo.Print();
        userRepo.Set(new User
        {
            Id = 5,
            FirstName = "John222",
            LastName = "Doe3333",
            Address = "N/A",
            PhoneNumber = "4445556667"
        });
        var user = userRepo.GetOne(x => x.Id == 5);
        Console.WriteLine(user.ToString());
        Console.WriteLine(user);
        //((IGenericRepo<User>)userRepo).Print();
        //((GenericRepo<User>)userRepo).Print();
        //userRepo.Print();
        //((IPrintable)userRepo).Print();
        //***********************************************/
        
        
        /*// using the virtual implementation

        var userRepoOverrideGeneric = new UserRepoOverridesGeneric(SeedUsers());
        userRepoOverrideGeneric.Print();
        userRepoOverrideGeneric.Set(new User
        {
            Address = "Jordan/Amman",
            Id = 6,
            FirstName = "Omar",
            LastName = "Ibraheem",
            PhoneNumber = "0798772695"
        });
        
        ((IGenericRepo<User>)userRepoOverrideGeneric).Print();
        ((GenericRepoAllowOverriding<User>)userRepoOverrideGeneric).Print();
        userRepoOverrideGeneric.Print();*/
        
        //Covariance and Contravariance

        var stack = new Stack<User>(new List<User>()
        {
            new User
            {
                Id=2,
                FirstName = "Omar",
                LastName = "Ibraheem",
                Address = "Jordan/Irbid",
                PhoneNumber = "0798772695",
            },
        });
        IPushable<User> pushable = stack;
        pushable.Push(new Student
        {
            Id=1,
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "0888888888",
            Address = "123 Main St", 
        });
        IPoppable<User> popable = stack;
        Console.WriteLine(popable.Pop().ToString());
        stack.Print();

    }


    static List<User> SeedUsers()
    {
        return new List<User>
        {
            new  User
            {
                Id=1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "0888888888",
                Address = "123 Main St",
            },
            new User
            {
                Id=2,
                FirstName = "Omar",
                LastName = "Ibraheem",
                Address = "Jordan/Irbid",
                PhoneNumber = "0798772695",
            },
            new User
            {
                Id=3,
                FirstName = "Sobhi",
                LastName="Fathi",
                PhoneNumber = "0155476321",
                Address = "Jordan/Amman"
            },
            new User
            {
                Id=4,
                FirstName="Fahti",
                LastName="Sobhi",
                Address = "Jordan/Karak",
                PhoneNumber = "0797772695",
            }
        };
    }

}
