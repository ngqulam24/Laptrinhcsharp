using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("Chuỗi đảo ngược: " + ReverseString(userInput));

            Console.Write("Nhập một chuỗi tìm kiếm: ");
            string searchString = Console.ReadLine();
            Console.WriteLine($"Số lần xuất hiện: {CountOccurrences(userInput, searchString)}");

            Console.Write("Nhập một chuỗi cũ: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Nhập một chuỗi mới: ");
            string newSubstring = Console.ReadLine();
            Console.WriteLine("Chuỗi đã được sửa: " + ReplaceSubstring(userInput, oldSubstring, newSubstring));

            Console.WriteLine("Chuỗi không có khoảng trắng: " + RemoveWhitespace(userInput));
        }

        static string ReverseString(string inputString)
        {
            return new string(inputString.ToCharArray().Reverse().ToArray());
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            return inputString.Split(new[] { searchString }, StringSplitOptions.None).Length - 1;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return inputString.Replace(" ", "");
        }
    }
}