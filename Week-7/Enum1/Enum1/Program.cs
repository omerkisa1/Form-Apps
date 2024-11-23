using System;

enum TrafficLight
{
    Red,
    Yellow,
    Green
}

class TrafficLightController
{
    public string GetAction(TrafficLight light)
    {
        switch (light)
        {
            case TrafficLight.Red:
                return "Stop!";
            case TrafficLight.Yellow:
                return "Get Ready!";
            case TrafficLight.Green:
                return "Go!";
            default:
                return "Unknown State";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        TrafficLightController trafficController = new TrafficLightController();
        Console.WriteLine("Kırmızı Işık Durumu: " + trafficController.GetAction(TrafficLight.Red)); 
        Console.WriteLine("Sarı Işık Durumu: " + trafficController.GetAction(TrafficLight.Yellow)); 
        Console.WriteLine("Yeşil Işık Durumu: " + trafficController.GetAction(TrafficLight.Green)); 

        Console.ReadLine();
    }
}
