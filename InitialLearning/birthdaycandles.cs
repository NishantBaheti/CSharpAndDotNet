using System;

class Solution {
    static int birthdayCakeCandles(int[] ar,int x) {
        int arCount;
        int maxh=0;
        arCount=x;
        int j=0;
        for(int i=0;i<arCount;i++){
            if(ar[i]>maxh){
                maxh=ar[i];
            }
        }
        for(int i=0;i<arCount;i++){
            if(ar[i]==maxh){
                j++;
            }
        }
        return j;
    }

    static void Main(string[] args) {
	int arCount = Convert.ToInt32(Console.ReadLine());
	int[] ar=new int[arCount];
	for(int i=0;i<arCount;i++){
		ar[i]=Convert.ToInt32(Console.ReadLine());
	}
	int result = birthdayCakeCandles(ar,arCount);

        Console.WriteLine(result);
   }

}
