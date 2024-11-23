using System;

class Program
{

    public int CalculateDifference(DateTime date1, DateTime date2)
    {
        return (int)(date2 - date1).TotalDays;
    }

    public int CalculateDifferenceInHours(DateTime date1, DateTime date2)
    {
        return (int)(date2 - date1).TotalHours;
    }


    public Tuple<int, int, int> CalculateDetailedDifference(DateTime date1, DateTime date2)
    {
        int years = date2.Year - date1.Year;
        int months = date2.Month - date1.Month;
        int days = date2.Day - date1.Day;

        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(date1.Year, date1.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        return Tuple.Create(years, months, days);
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        DateTime date1 = new DateTime(2020, 1, 1);
        DateTime date2 = new DateTime(2023, 6, 15);

  
        int dayDifference = program.CalculateDifference(date1, date2);
        Console.WriteLine("Gün Farkı: " + dayDifference);


        int hourDifference = program.CalculateDifferenceInHours(date1, date2);
        Console.WriteLine("Saat Farkı: " + hourDifference);


        var detailedDifference = program.CalculateDetailedDifference(date1, date2);
        Console.WriteLine($"Yıl: {detailedDifference.Item1}, Ay: {detailedDifference.Item2}, Gün: {detailedDifference.Item3}");

        Console.ReadLine();
    }
}
