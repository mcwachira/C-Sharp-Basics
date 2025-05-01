namespace C_Sharp_Basics;

public class StringConcatenation
{

    public static void BasicStringConcatenation()
    {
        Console.WriteLine("=> String concatenation:");
        string s1 = "Programming the ";
        string s2 = "PsychoDrill (PTP)";
        string s3 = String.Concat(s1 , s2);
        Console.WriteLine(s3);
        Console.WriteLine();
        
  
        string s4 = "Hello!";
        string s5 = "Y0";
        
        Console.WriteLine(s1.Equals(s2));
    
    }
}