namespace C_Sharp_Basics;

public class Password
{
    public static void PasswordChecker()
    {
        Console.WriteLine("Please Enter your  Password ");
        string password = Console.ReadLine();
        Console.WriteLine("PLease Enter your Password again ");
        string confirmPassword = Console.ReadLine();

        if (!password.Equals(String.Empty) && !confirmPassword.Equals(String.Empty))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("passwords match");
            }
            else
            {
                Console.WriteLine("passwords do not match");
            }
        }
        else
        {
            Console.WriteLine("please enter your password");
        }
    }
}