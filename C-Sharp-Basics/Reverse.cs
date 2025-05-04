namespace C_Sharp_Basics;

public class Reverse
{
    public static void StringReverse()
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length ; i++)
        {
            Console.Write(input[i]);
      
             
             
            Thread.Sleep(200);
             
        }

        Console.WriteLine();

        for (int i = input.Length-1; i >= 0; i--)
        {
             Console.Write(input[i]);
      
             
             
             Thread.Sleep(200);
             
        }



        Console.ReadLine();
    }
}