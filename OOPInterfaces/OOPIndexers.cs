namespace OOPInterfaces;

public class OOPIndexers
{
    private string[] names;

    public OOPIndexers()
    {
        names= new string[10];
    }

    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }


    public void TestDelegates(Func<int,int > test)
    {
        test += (t) => t + 1;
        test(1);

       
    }

}


