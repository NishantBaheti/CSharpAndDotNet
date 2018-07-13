
using System;

class Solution {
    static string solve(int[] a, int[] b) {
        int alice=0,bob=0;
	for(int i=0;i<3;i++){
		if(a[i]>b[i]){
			alice++;
		}else{
			if(a[i]<b[i]){
				bob++;
			}else{
				if(a[i]==b[i]){
					continue;
				}
			}
		}
	}
    string result=alice+" "+bob;
    return result;
    }

    static void Main(string[] args) {

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
        string result = solve(a, b);

        Console.WriteLine(string.Join(" ", result));

    }
}
