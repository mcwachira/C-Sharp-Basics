namespace C_Sharp_Basics;

public class Empty
{
    public static void StringEmpty()
    {
        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();
        if (name != string.Empty)
        {
            Console.WriteLine($"Your name is {name}");
        }
        else
        {
            Console.WriteLine("Name is Empty");
        }

        Console.ReadLine();
    }
}