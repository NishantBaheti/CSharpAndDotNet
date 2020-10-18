using System;
using System.IO;

public class PrimeNumber
{
	static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int x = 2; x < n; x++)
            {
            int isPrime = 0;
            for (int y = 1; y < x; y++)
                {
                if (x % y == 0)
                    isPrime++;

                if(isPrime == 2) 
                break;
                }
                if(isPrime != 2)
                    Console.Write(x+" ");
                    

                    isPrime = 0;
            }
        Console.ReadKey();
    }
}
