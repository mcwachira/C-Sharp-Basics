namespace C_Sharp_Basics;

public class Timetable
{
    public static void MultiplicationTable()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <=10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", i, num, i*num);
        }
    }
}