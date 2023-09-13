using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine(number + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(number + " is not a palindrome.");
            }
            Console.ReadLine();
        }

        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reverseNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reverseNumber;
        }
        
    }
}
