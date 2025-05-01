using System.Text;

namespace C_Sharp_Basics;

public class String_builder
{
    public static void FunWithStringBuilder()
    {
        Console.WriteLine("=> Using the String_builder");
        StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
        sb.AppendLine("\n");
        sb.AppendLine("Half Life");
        sb.AppendLine("Morrowind");
        sb.AppendLine("Deus Ex" + "2");
        sb.AppendLine("System Shock");
        Console.WriteLine(sb.ToString());
        sb.Replace("2", "Invisible War");
        Console.WriteLine(sb.ToString());
        Console.WriteLine("sb has {0} chars.", sb.Length);
        Console.WriteLine();
    }
}