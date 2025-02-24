class Program
{
    public static void Main()
    {
        string dateString1 = Console.ReadLine();
        string dateString2 = Console.ReadLine();

        DateDiff.FindDIff(dateString1, dateString2);
    }
}

class DateDiff
{
    public static void FindDIff(string dateString1, string dateString2)
    {
        DateTime date1 = DateTime.ParseExact(dateString1, "yyyy mm dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(dateString2, "yyyy mm dd", System.Globalization.CultureInfo.InvariantCulture);

        TimeSpan difference = date1 - date2;
        int result = Math.Abs(difference.Days);

        Console.WriteLine(result);
    }
}