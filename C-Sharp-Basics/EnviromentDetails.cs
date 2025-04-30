namespace C_Sharp_Basics;

public class EnviromentDetails
{
    //prints out the drives  details about my os
    public static void ShowEnvironmentDetails()
    {
        
 
     foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
        
    }
Console.WriteLine("OS: {0}", Environment.OSVersion);
Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
Console.WriteLine(".NET Core Version: {0}", Environment.Version);
}

}