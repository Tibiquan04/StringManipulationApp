using System;

namespace StringManipulationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string result1 = RemoveFirstCharacter(input);
            string result2 = RemoveLastCharacter(result1);

            Console.WriteLine(result2);
        }

        public static string RemoveFirstCharacter(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Substring(1);
        }

        public static string RemoveLastCharacter(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return input.Substring(0, input.Length - 1);
        }
    }
}
