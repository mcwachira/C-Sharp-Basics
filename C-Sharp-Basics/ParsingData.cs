namespace C_Sharp_Basics;

public class ParsingData
{

    public static void ParseFromString()
    {
        Console.WriteLine("=> Data type parsing");
        bool b = bool.Parse("True");
        Console.WriteLine($"Value of b: {b}");
        double d = double.Parse("123.456");
        Console.WriteLine($"Value of d: {d}");
        int i = int.Parse("8");
        Console.WriteLine($"Value of i: {i}");

        Console.WriteLine();
    }
}