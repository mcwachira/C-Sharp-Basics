namespace C_Sharp_Basics;

public class TriangleExercise
{
    public static void TriangleExerciseSolution()
    {
        
        //solution to check if angles of the triangle are equal


        const int angleCount = 3;
        int[] angles = new int[angleCount];

        for (int i = 0; i < angles.Length; i++)
        {
            Console.WriteLine($"Enter angle {i + 1}:");
            angles[i] = Convert.ToInt32(Console.ReadLine());
        }
        int angleSum = 0;

        foreach (int angle in angles)
        {
            angleSum += angle;
        }

        if (angleSum == 180)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        
    }
}