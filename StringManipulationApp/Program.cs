using System;

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string result1 = RemoveFirstCharacter(input);
            string result2 = RemoveLastCharacter(result1);

            Console.WriteLine(result2);
        }

        static string RemoveFirstCharacter(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Substring(1);
        }

        static string RemoveLastCharacter(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Substring(0, input.Length - 1);
        }
    }
}
