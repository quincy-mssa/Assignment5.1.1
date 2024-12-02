using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 353;
            bool isPalindrome = IsPalindrome(x);

            if (isPalindrome)
            {
                Console.WriteLine($"{x} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{x} is not a palindrome.");
            }
        }
        static bool IsPalindrome(int x)
        {
            if (x < 0) 
                return false;
            int originalNum = x;
            int reversedNum = 0;

            while (x > 0)
            {
                int digit = x % 10;
                reversedNum = reversedNum * 10 + digit;
                x /= 10;
            }

            return originalNum == reversedNum;

        }
    }
}
