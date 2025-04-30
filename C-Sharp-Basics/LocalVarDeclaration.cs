using System.Collections.Specialized;

namespace C_Sharp_Basics;

public class LocalVarDeclaration
{

    public static void LocalVar()
    {
        Console.WriteLine("=> Data  Declaration");

        int myInt = 0;
        string myString = "hello world";
        bool b1 = true, b2 = false, b3 = b1;
        
        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}",
            myInt, myString, b1, b2, b3);

    }
}