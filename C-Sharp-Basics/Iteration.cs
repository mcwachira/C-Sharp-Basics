using System.Threading;

namespace C_Sharp_Basics;

public class Iteration
{
    public static void StringIteration()
    {
        string message = "C# is awesome!";
        bool contains = false;
        for (int i = 0; i < message.Length; i++)
        {
            // Console.Write(message[i]);
            // Thread.Sleep(200);

   
            if (message[i].Equals('C'))
            {
                contains = true;
            }

         
        }
        
        
        Console.WriteLine(contains);
        Console.ReadLine();
    }
}