namespace C_Sharp_Basics;

public class ArrayReverse
{
    public static void ReverseArray()
    {
        int[] numbers = new int[]
        {
            1,2,3,4,5,6,7,8,9
        };
        
        int[] sortedNumbers = new int [numbers.Length];
        int x = 0;
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            sortedNumbers[x] = numbers[i];
            x++;
        }

        foreach (var num in sortedNumbers)
        {
            Console.WriteLine($"{num} ");
        }
    }
}