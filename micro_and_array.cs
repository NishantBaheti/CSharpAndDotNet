using System;

class Solution{
    static void Main(string[] args){
        int T=Convert.ToInt32(Console.ReadLine());
       
           for(int i=1;i<=T;i++){
               string s=Console.ReadLine();
               string[] token=s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
               int[] input=Array.ConvertAll(token,int.Parse);
               int n=Convert.ToInt32(input[0]);
               int k=Convert.ToInt32(input[1]);
               
               string s1=Console.ReadLine();
               string[] token1=s1.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
               int[] array=new int[n];
               for(int j=0;j<n;j++){
                   array[j]=Convert.ToInt32(token1[j]);
               }
               
               int time=0;
               
               Array.Sort(array);
               
               time= k - array[0];
               if(time<0){
                   Console.WriteLine("0");
               }
               else{
                   Console.WriteLine(time);
               }
           
        }
     
    
    }
}
