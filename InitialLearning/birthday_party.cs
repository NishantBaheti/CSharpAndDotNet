using System;

class solution{
    static void Main(string[] args){
        int t=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=t;i++){
            string s=Console.ReadLine();
            string[] token=s.Split();
            int[] input=Array.ConvertAll(token,int.Parse);
            if(input[1]%input[0]==0){
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
