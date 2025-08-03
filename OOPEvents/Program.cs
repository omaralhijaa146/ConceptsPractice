using System.Globalization;

namespace OOPEvents;

class Program
{
    static void Main(string[] args)
    {
        var messageManager = new MessageManager();
        
        messageManager.MessageSent += MessageSent;
        messageManager.OnMessageSent(new MessageInfo
        {
            Message = "Hello World",
            Sender = "Omar",
            Reciever = "Omar",
            Subject = "Hello World",
            DateTime = DateTime.Now
        });
    }

    public static void MessageSent(MessageInfo messageInfo)
    {
        Console.WriteLine("Message Sent");
        Console.WriteLine($"{messageInfo.Subject}");
        Console.WriteLine($"{messageInfo.Message}");
        Console.WriteLine($"{messageInfo.Sender}");
        Console.WriteLine($"{messageInfo.Reciever}");
        Console.WriteLine($"{messageInfo.DateTime.ToString("dd/MM/yyyy HH:m:s zzz",CultureInfo.InvariantCulture)}");
    }
    
}