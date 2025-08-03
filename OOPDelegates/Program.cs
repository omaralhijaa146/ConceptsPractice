namespace OOPDelegates;

class Program
{
    static void Main(string[] args)
    {
        var human = new Human("Omar", 20, () => "Believes in legends");
        human.DisplayHumanProperties();
    }
}