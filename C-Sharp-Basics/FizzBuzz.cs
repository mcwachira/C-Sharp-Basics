namespace C_Sharp_Basics;

public class FizzBuzz
{
    public static void FizzBuzzGame()
    {
        bool divisibleBythree = false;
        bool divisibleByFive = false;
        for (int i = 1; i <= 15; i++)
            
       
        
        {
             
            divisibleBythree = i % 3 == 0;
            divisibleByFive = i % 5 == 0;
            if ( divisibleBythree  && divisibleByFive)
            {

                Console.WriteLine($"{i} fizz buzz");
            }else if ( divisibleBythree) 
            {
                Console.WriteLine($"{i} fizz");
            } else if (divisibleByFive)
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