using System.Globalization;

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

        // Console.WriteLine(string.Format("-$10 /$3 = ${0:0.00}", money));
        // Console.WriteLine(money.ToString("C"));
        // Console.WriteLine(money.ToString("C0"));
        // Console.WriteLine(money.ToString("C1"));
        // Console.WriteLine(money.ToString("C2"));
        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-KE")));

        Console.ReadLine();
    }
}