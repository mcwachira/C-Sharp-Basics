namespace C_Sharp_Basics;

public class DateTimeExample
{
    public static void UseDateTime()
    {
        Console.WriteLine("=> Date and Time:");
        
        // This constructor takes (year, month, day).
        DateTime dt = new DateTime(2025, 04, 30);
        //what day of the month is this
        Console.WriteLine($"the day {dt.Date} is {dt.DayOfWeek}");
        
        //month is july
        dt = dt.AddMonths(2);
        Console.WriteLine($"the month {dt} is {dt.IsDaylightSavingTime()}");
        
        //represent half of the Date time type
        DateOnly d = new DateOnly(2025,04,30);
        Console.WriteLine(d);
    
        // This constructor takes (hours, minutes, seconds).
        TimeSpan ts = new TimeSpan(4, 30, 0);
        Console.WriteLine(ts);
    
        // Subtract 15 minutes from the current TimeSpan and
        // print the result.
        Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        
        //represent half of the Date time type
        TimeOnly t = new TimeOnly(13,30,0,0);
        Console.WriteLine(t);
    }
}