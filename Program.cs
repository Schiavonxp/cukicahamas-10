using System;
using System.Linq;

// cukicahamas-10 - C# Implementation
// A simple Hello World program

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to cukicahamas-10");
            
            // Simple calculation
            int[] numbers = { 1, 2, 3, 4, 5 };
            int total = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {total}");
        }
    }
}
