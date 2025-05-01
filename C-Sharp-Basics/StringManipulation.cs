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
        
        int age = 4;
        string name = "Soren";
        // Using curly-bracket syntax.
        string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
        Console.WriteLine(greeting);
    
        // Using string interpolation
        string greeting2 = $"Hello {name} you are {age} years old.";
        Console.WriteLine(greeting2);


        string s1 = "Hello!";
        string s2 = "Y0";
        
        Console.WriteLine(s1.Equals(s2));
    }
}