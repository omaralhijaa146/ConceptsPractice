namespace OOPStandardEventPattern;

class Program
{
    static void Main(string[] args)
    {
        var userEvents = new UserEvents();
        userEvents.UserUpdated += UserInfoChangedHandler;
        userEvents.ConfirmUser(1);
        userEvents.LogInUser(1);
        
        userEvents.ConfirmUser(2);
        userEvents.LogInUser(2);
        
    }

    public static void UserInfoChangedHandler(object? sender, UserInfoEventsArgs args)
    {
        Console.WriteLine("********************************");
        Console.WriteLine("********************************");
        Console.WriteLine();
        Console.WriteLine("Old User Info");
        Console.WriteLine($"ID => {args.OldUserInfo.Id}");
        Console.WriteLine($"NAME => {args.OldUserInfo.Name}");
        Console.WriteLine($"EMAIL => {args.OldUserInfo.Email}");
        Console.WriteLine($"USER LOGED IN => {(args.OldUserInfo.LogedIn?"YES":"NO")}");
        Console.WriteLine($"USER CONFIRMED => {(args.OldUserInfo.IsConfirmed?"YES":"NO")}");
        Console.WriteLine("********************************");
        Console.WriteLine("********************************");
        Console.WriteLine("********************************");
        Console.WriteLine("********************************");
        Console.WriteLine();
        Console.WriteLine("New User Info");
        Console.WriteLine($"ID => {args.NewUserInfo.Id}");
        Console.WriteLine($"NAME => {args.NewUserInfo.Name}");
        Console.WriteLine($"EMAIL => {args.NewUserInfo.Email}");
        Console.WriteLine($"USER LOGED IN => {(args.NewUserInfo.LogedIn?"YES":"NO")}");
        Console.WriteLine($"USER CONFIRMED => {(args.NewUserInfo.IsConfirmed?"YES":"NO")}");
        Console.WriteLine("********************************");
        Console.WriteLine("********************************");
    }
}