namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        var testIndexer = new TestIndexers();
        
        Console.WriteLine(testIndexer[0]);
        Console.WriteLine(testIndexer[1]);
        Console.WriteLine(testIndexer[2]);
        Console.WriteLine(testIndexer[3]);
        Console.WriteLine(testIndexer[4]);
        testIndexer[0] = 1;
        //testIndexer[4] = -1;
    }
}

public class TestIndexers
{
    private readonly int[] _arr = { 1,2,3,4,5};


    public int this[int index]
    {
        get => _arr[index];

        set
        {
            if (!(value < 0))
                _arr[index] = value;
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}