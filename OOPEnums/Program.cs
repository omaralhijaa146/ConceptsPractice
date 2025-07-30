namespace OOPEnums;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine(TestEnum.TestOne);
    }
}

public enum TestEnum
    :long{
    TestOne=1000000000000000000,
    TestTwo=1000000000000000000,
    TestThree=1000000000000000000
}

public class TT<U,T> where U : T
{
    
}

