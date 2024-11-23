using System;

enum Weather
{
    Sunny,
    Rainy,
    Cloudy,
    Stormy

}

class WeatherController
{
    public string GetAction(Weather stat)
    {
        switch (stat)
        {
            case Weather.Sunny:
                return "Time to go outside";
            case Weather.Rainy:
                return "Do not forget your umbrella";
            case Weather.Cloudy:
                return "It's fine take care to about rain anyway";
            case Weather.Stormy:
                return "Don't go outside!";
            default:
                return "Unknown State";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        WeatherController weather = new WeatherController();
        Console.WriteLine("Weather: " + weather.GetAction(Weather.Sunny));
        Console.WriteLine("Weather: " + weather.GetAction(Weather.Rainy));
        Console.WriteLine("Weather: " + weather.GetAction(Weather.Cloudy));
        Console.WriteLine("Weather: " + weather.GetAction(Weather.Stormy));

        Console.ReadLine();
    }
}
