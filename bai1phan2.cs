using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        double number = double.Parse(Console.ReadLine());

        int intNumber = (int)number;
        long longNumber = (long)number;

        Console.WriteLine($"The number you entered is {number}, as an int is {intNumber} and as a long is {longNumber}");
    }
}