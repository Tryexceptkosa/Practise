/*
 * A Fibonacci sequence is the sequence of numbers 1, 1, 2, 3, 5, 8, 13, 21, 34,
 * and so on, where each number (from the third on) is the sum of the previous two. 
 * Create a method that takes an integer as an argument and displays that many Fibonacci 
 * numbers starting from the beginning, e.g., If you run java Fibonacci 5 
 * (where Fibonacci is the name of the class) the output will be: 1, 1, 2, 3, 5. 
 */
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());  // n is count of Fib number;
            if (n == 1) Console.WriteLine("1");
            else if (n == 2) Console.WriteLine("1, 1");
            else if (n > 2)
            {
                Console.Write("1 1");
                int prev1 = 1;
                int prev2 = 1;
                for (int i = 2; i < n; i++)
                {
                    int num = prev1 + prev2;
                    Console.Write(" " + num);
                    prev1 = prev2;
                    prev2 = num;
                }
            }
            else Console.WriteLine("Invalid input (n <= 0) ");
            Console.WriteLine("\nPress any key to finish the program...");
            Console.ReadKey();
        }
    }
}
