using System.Reflection;

namespace OOPPartialTypes;

class Program
{
    static void Main(string[] args)
    {
        var std = new Student {StudentName = "Omar", HomeAddress = "Irbid/Jordan", BaseCountry = "Jordan"};
        
        foreach (var att in std.GetType().GetProperties())
        {
            Console.WriteLine(att.Name);   
            Console.WriteLine(att.Attributes.GetType().Name);   
        }
    }
}