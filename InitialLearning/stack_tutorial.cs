using System;
using System.Collections;

class solution{
    static void Main(string[] args){
        Stack st=new Stack();
        int t=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=t;i++){
            string s=Console.ReadLine();
            string[] token=s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            int[] input=Array.ConvertAll(token,int.Parse);
            if(input[0]==1){
                
                try{
                    Console.WriteLine("{0}",st.Peek());
                    st.Pop();
                    }
                catch(InvalidOperationException e1){
                    Console.WriteLine("No FOOD");
                }
            }
            else if(input[0]==2){
                st.Push(input[1]);
            }
            
        }
    }
}
