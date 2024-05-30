using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());

        double doubleNumber = (double)integer;

        Console.WriteLine($"The number you entered is {integer} and as a double is {doubleNumber}");
    }
}