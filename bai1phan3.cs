using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char character = char.Parse(Console.ReadLine());

        int asciiCode = (int)character;

        Console.WriteLine($"The character you entered is '{character}', its ASCII code is {asciiCode}");
    }
}