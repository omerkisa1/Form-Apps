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

        Console.ReadLine();
    }
}
