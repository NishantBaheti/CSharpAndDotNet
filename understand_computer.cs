using System;
class solution{
    static void Main(string[] args){
        long t=Convert.ToInt64(Console.ReadLine());
        long inc=0;
        for(long i=1;i<=t;i++){
            long n=Convert.ToInt64(Console.ReadLine());
            for(long j=2;j<=n;j++){
			    if(n/i>0){
			        inc++;
			    }
            }
            Console.WriteLine("{0}",inc);
            inc=0;
        }
    }
}
