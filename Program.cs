using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of integers in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter the integers:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxValue = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }

        Console.WriteLine($"The maximum value in the array is: {maxValue}");
    }
}