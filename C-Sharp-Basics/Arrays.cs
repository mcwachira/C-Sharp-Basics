using System.Globalization;

namespace C_Sharp_Basics;

public class Arrays
{
 public static void LearningArrays()
 {

  int[] numbers = new int[10];


   // Console.Write("Enter a number:");
   // numbers[0]= Convert.ToInt32(Console.ReadLine());
   // Console.Write("Enter a number:");
   // numbers[1]= Convert.ToInt32(Console.ReadLine());
   // Console.Write("Enter a number:");
   // numbers[2]= Convert.ToInt32(Console.ReadLine());
   // Console.Write("Enter a number:");
   // numbers[3]= Convert.ToInt32(Console.ReadLine());
   // Console.Write("Enter a number:");
   // numbers[4]= Convert.ToInt32(Console.ReadLine());   


   for (int i = 0; i < numbers.Length; i++)
   {
    Console.Write("Enter a number:");
    numbers[i]= Convert.ToInt32(Console.ReadLine());
   }
   
  // for (int i = 0; i < numbers.Length; i++)
  // {
  //  // numbers[i] = Convert.ToInt32(Console.ReadLine());
  //  Console.Write($"{numbers[i]}");
  // }

  foreach (int num in numbers )
  {

   Console.Write($"{num}");
  }
 }
}