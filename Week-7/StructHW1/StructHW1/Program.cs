using System;

struct Time
{
    private int hour;
    private int minute;

    public int Hour
    {
        get { return hour; }
        set { hour = (value >= 0 && value < 24) ? value : 0; }
    }

    public int Minute
    {
        get { return minute; }
        set { minute = (value >= 0 && value < 60) ? value : 0; }
    }


    public Time(int hour, int minute)
    {
        this.hour = (hour >= 0 && hour < 24) ? hour : 0;
        this.minute = (minute >= 0 && minute < 60) ? minute : 0;
    }

 
    public int ToTotalMinutes()
    {
        return (hour * 60) + minute;
    }

 
    public int DifferenceInMinutes(Time other)
    {
        return Math.Abs(this.ToTotalMinutes() - other.ToTotalMinutes());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Time time1 = new Time(12, 45);
        Time time2 = new Time(14, 30);

   
        Console.WriteLine("Time1 Toplam Dakika: " + time1.ToTotalMinutes()); 
        Console.WriteLine("Time2 Toplam Dakika: " + time2.ToTotalMinutes()); 

        Console.WriteLine("İki Zaman Arasındaki Fark (dakika): " + time1.DifferenceInMinutes(time2)); 

        Console.ReadLine();
    }
}
