using System;

class solution{
    static void Main(string[] args){
        int n=Convert.ToInt32(Console.ReadLine());
        long[] c=new long[n];
        string s1=Console.ReadLine();
        string[] token1=s1.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
        long[] a=Array.ConvertAll(token1,long.Parse);
        string s2=Console.ReadLine();
        string[] token2=s2.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
        long[] b=Array.ConvertAll(token2,long.Parse);
        for(int i=0;i<n;i++){
            c[i]=a[i]+b[i];
        }
        for(int i=0;i<n;i++){
            Console.Write("{0} ",c[i]);
        }
        
    }
}
