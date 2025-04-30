namespace C_Sharp_Basics;

public class basic_input_output
{
    public static void GetUserData()
    {
        Console.Write("Enter the name of the user:");
        string name = Console.ReadLine();
        Console.Write("Please Enter your age");
        string age = Console.ReadLine();
        
        // Change echo color, just for fun.
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        //display to the console.
        
        Console.WriteLine($"Hello {name} you are {age} years old");
        
        //restore previous color.
        Console.ForegroundColor = prevColor;
    }
}