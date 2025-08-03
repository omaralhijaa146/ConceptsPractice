namespace OOPDelegates;

public class Human
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    
    private List<string> _ideasInHumanBrain = new List<string>();
    
    protected Func<object>  HumanThinking;

    protected Action<string> IdeaInHumanBrain;

    
    
    public Human(string name, int age, Func<object> humanThinking)
    {
        Name = name;
        Age = age;
        HumanThinking = humanThinking;
        IdeaInHumanBrain = AddIdea;
    }

    private void AddIdea(object ideaInHumanBrain)
    {
        _ideasInHumanBrain.Add((string) ideaInHumanBrain);
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
        Console.WriteLine($"Human ideas => {string.Join("; ",_ideasInHumanBrain)}");
    }
    
    public void AddIdeaInHumanBrain(string ideaInHumanBrain)
    {
        IdeaInHumanBrain(ideaInHumanBrain);
        Console.WriteLine("Added Successfully");
    }

}