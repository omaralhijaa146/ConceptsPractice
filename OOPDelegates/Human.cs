namespace OOPDelegates;

public class Human
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    
    protected Func<string>  HumanThinking;

    public Human(string name, int age, Func<string> humanThinking)
    {
        Name = name;
        Age = age;
        HumanThinking = humanThinking;
    }

    public void DisplayHumanProperties()
    {
        Console.WriteLine();
        Console.WriteLine("****************************");
        Console.WriteLine("****************************");
        Console.WriteLine();
        Console.WriteLine("Human Properties");
        Console.WriteLine();
        Console.WriteLine("****************************");
        Console.WriteLine();
        Console.WriteLine($"Human name => {Name}");
        Console.WriteLine($"Human age => {Age}");
        Console.WriteLine($"Human thinking => {HumanThinking()}");
    }


}