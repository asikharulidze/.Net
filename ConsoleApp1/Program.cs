using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the year of birth:");
        int birthYear = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine("Your age is: " + age);
    }
}