using System;

struct ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }


    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }


    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
    }

    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

struct GpsLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }


    public GpsLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }


    public double DistanceTo(GpsLocation other)
    {
        const double R = 6371; 
        double lat1Rad = ToRadians(this.Latitude);
        double lon1Rad = ToRadians(this.Longitude);
        double lat2Rad = ToRadians(other.Latitude);
        double lon2Rad = ToRadians(other.Longitude);

        double deltaLat = lat2Rad - lat1Rad;
        double deltaLon = lon2Rad - lon1Rad;

        double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                   Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                   Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c; 
    }

    private static double ToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        ComplexNumber complex1 = new ComplexNumber(3, 4);
        ComplexNumber complex2 = new ComplexNumber(1, 2);

      
        ComplexNumber sum = complex1.Add(complex2);
        Console.WriteLine("Toplama Sonucu: " + sum); 

     
        ComplexNumber difference = complex1.Subtract(complex2);
        Console.WriteLine("Çıkarma Sonucu: " + difference); 
        
        GpsLocation location1 = new GpsLocation(40.7128, -74.0060); 
        GpsLocation location2 = new GpsLocation(34.0522, -118.2437); 

  
        double distance = location1.DistanceTo(location2);
        Console.WriteLine("İki GPS Konumu Arasındaki Mesafe: " + distance + " km");

        Console.ReadLine();
    }
}
