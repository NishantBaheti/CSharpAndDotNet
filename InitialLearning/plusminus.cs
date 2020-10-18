using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr,int x)
    {
        float i=0,j=0,k=0;
        int n;
        n=x;
        for(int l=0;l<n;l++)
        {
            if(arr[l]>0)
            {
                i++;
            }
            if(arr[l]<0)
            {
                j++;
            }
            if(arr[l]==0)
            {
                k++;
            }
        }
        
        Console.WriteLine("{0}",String.Format("{0:F6}", i/n));
        Console.WriteLine("{0}",String.Format("{0:F6}", j/n));
        Console.WriteLine("{0}",String.Format("{0:F6}", k/n));
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr,n);
    }
}

