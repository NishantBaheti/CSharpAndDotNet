using System;

class Solution {
    static void miniMaxSum(long[] arr) {
        long min=0;
        long max=0;
        long sum=0;
        long[] a=new long[10];
       for(int i=0;i<5;i++){
               sum=sum+arr[i];
            }
        for(int i=0;i<5;i++){
            a[i]=sum-arr[i];
        }
        for(int i=0;i<5;i++){
            if(a[i]>max){
                max=a[i];
            }
        }
        min=max;
        for(int i=0;i<5;i++){
            if(a[i]<min){
                min=a[i];
            }
        }
        Console.WriteLine("{0} {1}",min,max);
           
       }

    static void Main(string[] args) {
	long[] arr=new long[5];
	for(int i=0;i<5;i++){
		arr[i]=long.Parse(Console.ReadLine());
	}
        miniMaxSum(arr);
    }
}

