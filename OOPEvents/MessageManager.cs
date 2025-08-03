namespace OOPEvents;

public class MessageManager
{
    
    public event MessageHandler MessageSent;
    
    public void OnMessageSent(MessageInfo messageInfo)
    {
        if (MessageSent is null) return;
        
        MessageSent(messageInfo);
    }
    
    
    
}