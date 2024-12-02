using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5._1._1
    //Given an integer x, return true if x is a palindrome, and false otherwise
    //Example 1:
    //Input: x = 121
    //Output: true
    //Explanation: 121 reads as 121 from left to right and from right to left.
    //Example 2:
    //Input: x = -121
    //Output: false
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
