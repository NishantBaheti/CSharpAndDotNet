using System;

class solution{
    static void Main(string[] args){
        while(true){
        try{
            long n=long.Parse(Console.ReadLine());
        string result = string.Empty;
        int bit=0;
        long remainder=0;
            while (n >0)
            {
                remainder =n % 2;
                n/= 2;
                result = remainder.ToString() + result;
            }
        for(int i=0;i<result.Length;i++){
            if(result[i]=='1'){
                bit++;
            }
        }
        Console.WriteLine("{0}",bit);
        }
        catch(ArgumentNullException e1){
            break;
        }    
        }
    }
}
