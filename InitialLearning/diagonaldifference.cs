using System;

class Solution {
    static int diagonalDifference(int[,] arr,int x) {
        int n=x;
        int sum1=0;
        int sum2=0;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(i==j){
                    sum1=sum1+arr[i,j];
                }
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if((i+j)==n-1){
                    sum2=sum2+arr[i,j];
                }
            }
        }
        int diff=Math.Abs(sum1-sum2);
        return diff;


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[n,n];

        for (int i = 0; i < n; i++){
			for(int j = 0 ; j < n ; j++){
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
        }

        int result = diagonalDifference(arr,n);

        Console.WriteLine(result);
	}
}
