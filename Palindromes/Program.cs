using System;
using System.Collections.Generic;


namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Word To See If It's A Palindrome.");
            string myString = Console.ReadLine().ToLower();
            var inputString = "";
            var compareString = "";

            foreach(char mychar in myString)
            {
                if (!char.IsPunctuation(mychar))
                {
                    inputString += mychar;
                }
            }
            inputString = inputString.Replace(" ", string.Empty);
            compareString = ReverseString(inputString);

            if (compareString == inputString)
            {
                Console.WriteLine("You Made A Sarah Palindrome");
            }
            else
            {
                Console.WriteLine("You Wrong, Scooter!");
            }

            Console.ReadLine();
        }
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
