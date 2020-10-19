using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppExploration
{
    class Program
    {
        static void exploreIf()
        {
            int a = 5;
            int b = 3;
            int c = 5;

            if ((a+b+c >10) && a > b)
            {
                Console.WriteLine("both sum is greater than 10 and a is greater than b");
            }
            else
            {
                Console.WriteLine("Either sum is less than 10 or a is not greater than b");
            }
        }
        
        static void exploreFor(int n)
        {
            var fibonacciNumber = new List<int> { 1, 1 };
            int prevNumber1 = 0;
            int prevNumber2 = 0;
            for(int i = 0; i <= n; i++)
            {
                prevNumber1 = fibonacciNumber[fibonacciNumber.Count - 1];
                prevNumber2 = fibonacciNumber[fibonacciNumber.Count - 2];

                fibonacciNumber.Add(prevNumber1 + prevNumber2);
            }

            foreach(var number in fibonacciNumber)
            {
                Console.WriteLine($"{number}");
            }
        }

        static void exploreWhile(int n)
        {
            var fibonacciNumber = new List<int> { 1, 1 };
            int prevNumber1 = 0;
            int prevNumber2 = 0;
            int i = 0;
            while(i <= n){
                prevNumber1 = fibonacciNumber[fibonacciNumber.Count - 1];
                prevNumber2 = fibonacciNumber[fibonacciNumber.Count - 2];

                fibonacciNumber.Add(prevNumber1 + prevNumber2);

                i += 1;
            }

            foreach (var number in fibonacciNumber)
            {
                Console.WriteLine($"{number}");
            }
        }
        static void Main(string[] args)
        {
            //Printing Hello World
            Console.WriteLine("Hello World!");

            //Branching 
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("Greater than 10");
            else
                Console.WriteLine("Less than 10");

            //Testing function
            exploreIf();

            // loops
            // for loop
            exploreFor(20);

            // while loop
            exploreWhile(20);
        }
    }
}
