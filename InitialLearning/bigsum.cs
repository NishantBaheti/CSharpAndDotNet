using System;

class Solution {

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar,int x) {
        long sum=0;
        int arCount=x;
        for(int i=0;i<arCount;i++){
            sum=sum+ar[i];
        }
        return sum;


    }

    static void Main(string[] args) {
        
        int arCount = Convert.ToInt32(Console.ReadLine());
	long[] ar=new long[10];

        for(int i=0;i<arCount;i++){
		ar[i]=Convert.ToInt64(Console.ReadLine());
	}
	long result = aVeryBigSum(ar,arCount);

        Console.WriteLine(result);
    }
}
