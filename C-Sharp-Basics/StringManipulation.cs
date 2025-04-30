namespace C_Sharp_Basics;

public class StringManipulation
{

  public  static void BasicStringFunctionality()
    {
        Console.WriteLine("BasicStringFunctionality");
        string firstName = "Charles";
        Console.WriteLine($"value of first name  is {firstName}");
        Console.WriteLine($"firstName in uppercase is {firstName.ToUpper()}");
        Console.WriteLine($"firstName in lowercase is {firstName.ToLower()}");
        Console.WriteLine($"firstName contains the letter s? {firstName.Contains("s")}");
        Console.WriteLine($"New  first name {firstName.Replace("es", "i")}");
        Console.WriteLine();
    }
}