using System;

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
        static void Main(string[] args)
        {
            //Printing Hello World
            //Console.WriteLine("Hello World!");

            //Branching 
            //int a = 5;
            //int b = 6;
            //if (a + b > 10)
            //    Console.WriteLine("Greater than 10");
            //else
            //    Console.WriteLine("Less than 10");

            //Testing function
            exploreIf();
        }
    }
}
