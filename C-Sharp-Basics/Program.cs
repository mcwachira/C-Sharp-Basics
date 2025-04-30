using C_Sharp_Basics;

class Program
{
    //no return type
    static void Main(string[] args)
    {
        // Display a simple message to the user.
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello World!");
        Console.WriteLine();
        EnviromentDetails.ShowEnvironmentDetails();
        // Wait for Enter key to be pressed before shutting down.
        Console.ReadLine();

     

    }
}