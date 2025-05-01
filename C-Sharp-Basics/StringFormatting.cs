namespace C_Sharp_Basics;

public class StringFormatting
{
    public static void FormatString()
    {
        double value = 1000D / 12.34D;

        Console.WriteLine(value);
        Console.WriteLine(string.Format("{0:0}", value));
        Console.WriteLine(string.Format("{0:0.0}", value));
        Console.WriteLine(string.Format("{0:0.00}", value));
        Console.WriteLine(string.Format("{0:0.0000}", value));
        Console.WriteLine(string.Format("{0:0.00000}", value));

        double money = 10d / 3d;

        Console.ReadLine();
    }
}