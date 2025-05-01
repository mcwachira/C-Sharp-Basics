namespace C_Sharp_Basics;

public class FizzBuzz
{
    public static void FizzBuzzGame()
    {
        for (int i = 1; i <= 15; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {

                Console.WriteLine($"{i} fizz buzz");
            }else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} fizz");
            } else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} f buzz");
            }
            else
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}