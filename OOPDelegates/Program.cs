namespace OOPDelegates;

class Program
{
    static void Main(string[] args)
    {
       var humanThinking = "Believes in legends";
        
        var human = new Human("Omar", 20, () => humanThinking);
        human.DisplayHumanProperties();
        
        human.AddIdeaInHumanBrain("Eat heathy food");
        human.AddIdeaInHumanBrain("Work");
        human.AddIdeaInHumanBrain("Pray");
        human.DisplayHumanProperties();
    }
    
    
}