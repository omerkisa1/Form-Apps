using System;
using System.Collections.Generic;

class StudentGrades
{

    private Dictionary<string, int> grades = new Dictionary<string, int>();

   
    public int this[string courseName]
    {
        get
        {
            if (grades.ContainsKey(courseName))
            {
                return grades[courseName]; 
            }
            else
            {
                throw new KeyNotFoundException($"Ders '{courseName}' bulunamadı.");
            }
        }
        set
        {
            grades[courseName] = value;
        }
    }

   
    public void PrintAllGrades()
    {
        foreach (var course in grades)
        {
            Console.WriteLine($"Ders: {course.Key}, Not: {course.Value}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentGrades studentGrades = new StudentGrades();

   
        studentGrades["Matematik"] = 90;
        studentGrades["Fizik"] = 85;
        studentGrades["Kimya"] = 78;

        Console.WriteLine("Matematik Notu: " + studentGrades["Matematik"]); 
        Console.WriteLine("Fizik Notu: " + studentGrades["Fizik"]);       

      
        try
        {
            Console.WriteLine(studentGrades["Biyoloji"]); 
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message); 
        }

       
        studentGrades.PrintAllGrades();

        Console.ReadLine();
    }
}
