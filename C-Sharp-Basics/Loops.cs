namespace C_Sharp_Basics;

public class Loops
{
    public static void basicLoops()
    {
        Console.WriteLine("Please enter the value of number a");
        int a = Convert.ToInt32( Console.ReadLine());
       
        Console.WriteLine("Please enter the value of number b");
        int b = Convert.ToInt32( Console.ReadLine());

        int answer = a * b;
        int actualAnswer = 0;
        Console.WriteLine($"What is the  value of {a} and {b}?");


        // while (answer != actualAnswer)
        // {
        //     Console.WriteLine("Please enter your answer:");
        //     string answerInput = Console.ReadLine();
        //     actualAnswer = Convert.ToInt32(answerInput);
        //     if (answer != actualAnswer)
        //     {
        //         Console.WriteLine("Close but it wrong!");
        //         Console.WriteLine();
        //     }
        // }


        do
        {
            Console.WriteLine("Please enter your answer:");
            string answerInput = Console.ReadLine();
            actualAnswer = Convert.ToInt32(answerInput);
            if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it wrong!");
                Console.WriteLine();
            }
        }while (answer != actualAnswer) ;
        Console.WriteLine("Well Done");
    }
}