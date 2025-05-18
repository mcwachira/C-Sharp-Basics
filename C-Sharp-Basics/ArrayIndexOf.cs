using System.Globalization;

namespace C_Sharp_Basics;

public class ArrayIndexOf
{
    public static void FindIndexOfValueInArray()
    {

        int [] numbers = new int[]
        {
            90,199,22,50,30
        };
        Console.WriteLine("Enter a Number to Search: ");
        int searchNumber = Convert.ToInt32(Console.ReadLine());
        int position = Array.IndexOf(numbers, searchNumber);

        // if (position > -1)
        // {
        //     Console.WriteLine($"Number {searchNumber} found at index {position + 1}");
        // }
        // else
        // {
        //     Console.WriteLine("Number not found");
        // }
    }
}