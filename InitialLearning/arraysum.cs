using System;

namespace arraysum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {
                sum = sum + arr[j];
            }
            Console.WriteLine("{0}",sum);
            Console.ReadKey();
        }
    }
}
