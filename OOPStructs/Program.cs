namespace OOPStructs;

class Program
{
    static void Main(string[] args)
    {
        var testStruct = new TestStruct(88, 99);
        Console.WriteLine($"firstValue {testStruct.firstValue} / Second Value{testStruct.secondValue}");
    }
}


public struct TestStruct
{
    public int firstValue;
    public int secondValue;

    public TestStruct(int val1,int val2)
    {
        firstValue = val1;
        secondValue = val2;
    }
}





