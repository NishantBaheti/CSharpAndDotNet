using System;

class array_insert{
    static void Main(string[] args){
        string input_string=Console.ReadLine();
        string[] tokens=input_string.Split();
        int[] input=Array.ConvertAll(tokens, int.Parse);
        int n=input[0];
        int q=input[1];
        int sum=0;
        string array=Console.ReadLine();
        string[] tokens1=array.Split();
        int[] input_array=Array.ConvertAll(tokens1,int.Parse);
        
        for(int i=0;i<q; i++){
            string query=Console.ReadLine();
            string[] tokens3=query.Split();
            int[] input_query=Array.ConvertAll(tokens3,int.Parse);
            if(input_query[0]==1){
                input_array[input_query[1]]=input_query[2];
            }
            else if(input_query[0]==2){
                if(input_query[2]<input_array.Length){
                    for(int j=input_query[1];j<=input_query[2];j++){
                        sum=sum+input_array[j];
                    }
                    Console.WriteLine("{0}",sum);
                }
                else
                    Console.WriteLine("-1");
            }
        }
        
        
    }
}
