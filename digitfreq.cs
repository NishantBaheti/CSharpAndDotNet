using System;

class Solution{
    
    static void Main(string[] args){
        int[] a=new int[10];
	string size = Console.ReadLine();
        int s1=Convert.ToInt32(size);
        int[] s=new int[size.Length];
        for(int i=0;i<size.Length;i++){
	    int values = s1%10;
	    s1 /= 10;
	    s1 = (int)s1;
            s[i]=values;
        }
        for(int i=0;i<s.Length;i++){
            if(s[i]==0){
                a[0]++;
            }
            else if(s[i]==1){
                a[1]++;
            }
            
            else if(s[i]==2){
                a[2]++;
            }
            
            else if(s[i]==3){
                a[3]++;
            }
            
            else if(s[i]==4){
                a[4]++;
            }
            
            else if(s[i]==5){
                a[5]++;
            }
            
            else if(s[i]==6){
                a[6]++;
            }
            
            else if(s[i]==7){
                a[7]++;
            }
            
            else if(s[i]==8){
                a[8]++;
            }
            
            else if(s[i]==9){
                a[9]++;
            }
        }
        for(int i=0;i<=9;i++){
            Console.WriteLine("{0} {1}",i,a[i]);
        }
        
    }
}
