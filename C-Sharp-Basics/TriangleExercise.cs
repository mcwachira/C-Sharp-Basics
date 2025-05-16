namespace C_Sharp_Basics;

public class TriangleExercise
{
    public static void TriangleExerciseSolution()
    {
        
        //solution to check if angles of the triangle are equal


        const int angleCount = 3;
        int angleSum = 0;

        for (int i = 0; i < angleCount; i++)
        {
            Console.WriteLine($"Enter angle {i + 1}:");
      
        
        angleSum +=   Convert.ToInt32(Console.ReadLine());
        }

    Console.WriteLine(angleSum == 180 ? "Valid":"Invalid");


        
    }
}